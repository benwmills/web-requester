using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

using System.Web;
using System.Net;

namespace MillsSoftware.WebRequester
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class frmMain : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox txtUrl;
		private System.Windows.Forms.Button btnRequest;
		private System.Windows.Forms.Label lblResponseCode;
		private System.Windows.Forms.TextBox txtResponseCode;
		private System.Windows.Forms.TextBox txtLocation;
		private System.Windows.Forms.Label lblLocation;
		private System.Windows.Forms.Label lblStatusDescription;
		private System.Windows.Forms.TextBox txtStatusDescription;
		private System.Windows.Forms.ListView lvwHeaders;
		private System.Windows.Forms.Label lblHeaders;
		private System.Windows.Forms.ColumnHeader HeaderName;
		private System.Windows.Forms.ColumnHeader HeaderValue;
		private CheckBox chkFollowRedirects;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmMain()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.txtUrl = new System.Windows.Forms.TextBox();
			this.btnRequest = new System.Windows.Forms.Button();
			this.lblResponseCode = new System.Windows.Forms.Label();
			this.txtResponseCode = new System.Windows.Forms.TextBox();
			this.lblLocation = new System.Windows.Forms.Label();
			this.txtLocation = new System.Windows.Forms.TextBox();
			this.lblStatusDescription = new System.Windows.Forms.Label();
			this.txtStatusDescription = new System.Windows.Forms.TextBox();
			this.lblHeaders = new System.Windows.Forms.Label();
			this.lvwHeaders = new System.Windows.Forms.ListView();
			this.HeaderName = new System.Windows.Forms.ColumnHeader();
			this.HeaderValue = new System.Windows.Forms.ColumnHeader();
			this.chkFollowRedirects = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// txtUrl
			// 
			this.txtUrl.Location = new System.Drawing.Point(24, 40);
			this.txtUrl.Name = "txtUrl";
			this.txtUrl.Size = new System.Drawing.Size(424, 21);
			this.txtUrl.TabIndex = 0;
			this.txtUrl.Text = "http://www.google.com/badpage";
			// 
			// btnRequest
			// 
			this.btnRequest.Location = new System.Drawing.Point(581, 40);
			this.btnRequest.Name = "btnRequest";
			this.btnRequest.Size = new System.Drawing.Size(75, 23);
			this.btnRequest.TabIndex = 2;
			this.btnRequest.Text = "Request";
			this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
			// 
			// lblResponseCode
			// 
			this.lblResponseCode.Location = new System.Drawing.Point(32, 96);
			this.lblResponseCode.Name = "lblResponseCode";
			this.lblResponseCode.Size = new System.Drawing.Size(100, 23);
			this.lblResponseCode.TabIndex = 3;
			this.lblResponseCode.Text = "Response Code:";
			// 
			// txtResponseCode
			// 
			this.txtResponseCode.Location = new System.Drawing.Point(160, 96);
			this.txtResponseCode.Name = "txtResponseCode";
			this.txtResponseCode.Size = new System.Drawing.Size(136, 21);
			this.txtResponseCode.TabIndex = 4;
			// 
			// lblLocation
			// 
			this.lblLocation.Location = new System.Drawing.Point(32, 160);
			this.lblLocation.Name = "lblLocation";
			this.lblLocation.Size = new System.Drawing.Size(100, 23);
			this.lblLocation.TabIndex = 7;
			this.lblLocation.Text = "Location:";
			// 
			// txtLocation
			// 
			this.txtLocation.Location = new System.Drawing.Point(160, 160);
			this.txtLocation.Name = "txtLocation";
			this.txtLocation.Size = new System.Drawing.Size(496, 21);
			this.txtLocation.TabIndex = 8;
			// 
			// lblStatusDescription
			// 
			this.lblStatusDescription.Location = new System.Drawing.Point(32, 128);
			this.lblStatusDescription.Name = "lblStatusDescription";
			this.lblStatusDescription.Size = new System.Drawing.Size(120, 23);
			this.lblStatusDescription.TabIndex = 5;
			this.lblStatusDescription.Text = "Status Description:";
			// 
			// txtStatusDescription
			// 
			this.txtStatusDescription.Location = new System.Drawing.Point(160, 128);
			this.txtStatusDescription.Name = "txtStatusDescription";
			this.txtStatusDescription.Size = new System.Drawing.Size(136, 21);
			this.txtStatusDescription.TabIndex = 6;
			// 
			// lblHeaders
			// 
			this.lblHeaders.Location = new System.Drawing.Point(32, 192);
			this.lblHeaders.Name = "lblHeaders";
			this.lblHeaders.Size = new System.Drawing.Size(100, 23);
			this.lblHeaders.TabIndex = 9;
			this.lblHeaders.Text = "Headers:";
			// 
			// lvwHeaders
			// 
			this.lvwHeaders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.HeaderName,
            this.HeaderValue});
			this.lvwHeaders.FullRowSelect = true;
			this.lvwHeaders.GridLines = true;
			this.lvwHeaders.Location = new System.Drawing.Point(160, 192);
			this.lvwHeaders.Name = "lvwHeaders";
			this.lvwHeaders.Size = new System.Drawing.Size(496, 272);
			this.lvwHeaders.TabIndex = 10;
			this.lvwHeaders.UseCompatibleStateImageBehavior = false;
			this.lvwHeaders.View = System.Windows.Forms.View.Details;
			// 
			// HeaderName
			// 
			this.HeaderName.Text = "Name";
			this.HeaderName.Width = 131;
			// 
			// HeaderValue
			// 
			this.HeaderValue.Text = "Value";
			this.HeaderValue.Width = 310;
			// 
			// chkFollowRedirects
			// 
			this.chkFollowRedirects.AutoSize = true;
			this.chkFollowRedirects.Location = new System.Drawing.Point(460, 42);
			this.chkFollowRedirects.Name = "chkFollowRedirects";
			this.chkFollowRedirects.Size = new System.Drawing.Size(115, 17);
			this.chkFollowRedirects.TabIndex = 1;
			this.chkFollowRedirects.Text = "Follow redirects";
			this.chkFollowRedirects.UseVisualStyleBackColor = true;
			// 
			// frmMain
			// 
			this.AcceptButton = this.btnRequest;
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(688, 494);
			this.Controls.Add(this.chkFollowRedirects);
			this.Controls.Add(this.lvwHeaders);
			this.Controls.Add(this.lblHeaders);
			this.Controls.Add(this.txtStatusDescription);
			this.Controls.Add(this.lblStatusDescription);
			this.Controls.Add(this.txtLocation);
			this.Controls.Add(this.lblLocation);
			this.Controls.Add(this.txtResponseCode);
			this.Controls.Add(this.lblResponseCode);
			this.Controls.Add(this.btnRequest);
			this.Controls.Add(this.txtUrl);
			this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "frmMain";
			this.Text = "Web Request";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new frmMain());
		}

		private void btnRequest_Click(object sender, System.EventArgs e)
		{
			System.Net.HttpWebRequest objRequest;
			System.Net.HttpWebResponse objResponse;

			objRequest = WebRequest.Create(this.txtUrl.Text) as HttpWebRequest;
			objRequest.AllowAutoRedirect = this.chkFollowRedirects.Checked;

			try
			{
				objResponse = objRequest.GetResponse() as HttpWebResponse;

				this.txtResponseCode.Text = objResponse.StatusCode.ToString("D") + " (" + objResponse.StatusCode.ToString() + ")";
				this.txtStatusDescription.Text = objResponse.StatusDescription;
				this.txtLocation.Text = objResponse.GetResponseHeader("Location");

				this.lvwHeaders.Items.Clear();
				foreach (string HeaderName in objResponse.Headers.Keys)
				{
					ListViewItem item = this.lvwHeaders.Items.Add(HeaderName);
					item.SubItems.Add(objResponse.Headers[HeaderName]);
				}

				objResponse.Close();
			}
			catch (WebException ex)
			{
				objResponse = ex.Response as HttpWebResponse;
				this.txtResponseCode.Text = objResponse.StatusCode.ToString("D") + " (" + objResponse.StatusCode.ToString() + ")";
				this.txtStatusDescription.Text = objResponse.StatusDescription;
				this.txtLocation.Text = objResponse.GetResponseHeader("Location");
				objResponse.Close();
			}

//			MessageBox.Show("Done.");

		}
	}
}
