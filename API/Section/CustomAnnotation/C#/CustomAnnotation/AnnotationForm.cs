using System;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;
using GrapeCity.ActiveReports;
using System.Xml;
using GrapeCity.ActiveReports.Document.Section.Annotations;
using System.Drawing.Imaging;

namespace ActiveReports.Samples.CustomAnnotation
{
	public partial class AnnotationForm : Form
	{
		/// <summary>
		/// A description of the overview of the Annotation Form.
		/// </summary>
		public AnnotationForm()
		{
			InitializeComponent();
		}

		private void AnnotationForm_Load(object sender, EventArgs e)
		{
			var resource = new ResourceManager(GetType());
			// Add custom button for annotation.
			ToolStrip ts = arvMain.Toolbar.ToolStrip;
			ToolStripButton tsbAnnotation = new ToolStripButton(resource.GetString("CustomAnnotation"));
			
			tsbAnnotation.Click += new EventHandler(tsbAnnotation_Click);
			ts.Items.Add(tsbAnnotation);

			//Load report layout and run report
			SectionReport report = new SectionReport();
			report.LoadLayout(XmlReader.Create(Properties.Resources.FileName));
			report.Document.Printer.PrinterName = String.Empty;	
			arvMain.LoadDocument(report);
		}

		void tsbAnnotation_Click(object sender, EventArgs e)
		{
			//Depending on the presence or absence of annotation, to display the confirmation message. 
			if (arvMain.Document.Pages[arvMain.ReportViewer.CurrentPage - 1].Annotations.Count > 0)
			{
				MessageBox.Show(Properties.Resources.StampMessage, Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			// Gets the image from a resource seal.
			System.Reflection.Assembly thisExe;
			thisExe = System.Reflection.Assembly.GetExecutingAssembly();
			System.IO.Stream file = thisExe.GetManifestResourceStream("ActiveReports.Samples.CustomAnnotation.Resources.stamp.png");

			var imgStamp = new Bitmap(file);

			// Create an annotation, you can assign the value of the property.
			AnnotationImage annoImg = new AnnotationImage();
			annoImg.BackgroundImage = ToInternalImage(imgStamp);			 // Image
			annoImg.Color = Color.Transparent;			  //Background color
			annoImg.BackgroundLayout = GrapeCity.ActiveReports.Document.Section.Annotations.ImageLayout.Zoom; // Display format
			annoImg.ShowBorder = false;					 //Display border (hidden) 

			// Add a comment.
			// (Specify the additional position)
			annoImg.Attach(6.09F, 1.19F);
			arvMain.Document.Pages[arvMain.ReportViewer.CurrentPage - 1].Annotations.Add(annoImg);
			// (Set the size)
			annoImg.Height = 0.7F;
			annoImg.Width = 0.7F;

			//To update the Viewer. 
			arvMain.Refresh();
		}

		public GrapeCity.ActiveReports.Document.Drawing.Image ToInternalImage(System.Drawing.Image image)
		{
			using (var ms = new MemoryStream())
			{
				image.Save(ms, ImageFormat.Png);
				return GrapeCity.ActiveReports.Document.Drawing.Image.FromStream(ms);
			}
		}
	}
}
