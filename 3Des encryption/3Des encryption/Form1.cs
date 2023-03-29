using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;

namespace _3Des_encryption
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       bool uspech = false;


        //Při spuštění programu.
        private void Form1_Load(object sender, EventArgs e)
        {
            KoncovkaTxt.Hide();
            KoncovkaLabel.Hide();
        }
        //
        //


        //Odkaz na stránku pro testování silnost hesla
        private void PasswordStreng_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.passwordmonster.com/");
        }

        private void PasswordStreng2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.passwordmonster.com/");
        }

        //
        //


        //Generace hesla
        private void Generate1_Click(object sender, EventArgs e)
        {
           
            
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789*_?.;+=@:-/<>#&$~[]{},\"|";
            var stringChars = new char[16];
            var random = new Random();
            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }
            var finalString = new String(stringChars);

            pass1TXT.Text = finalString;
        }
        
        private void Generate2_Click(object sender, EventArgs e)
        {
    
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789*_?.;+=@:-/<>#&$~[]{},\"|";
            var stringChars = new char[16];
            var random = new Random();
            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }
            var finalString = new String(stringChars);

            pass2TXT.Text = finalString;
        }
        //
        //


        //Vyhledávání souborů pro šifrování
        private void btnSeach1_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.Multiselect = false;
            if (od.ShowDialog() == DialogResult.OK)
            {
                path1TXT.Text = od.FileName;
            }
        }

        private void btnSeach2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                path2TXT.Text = dialog.SelectedPath;
            }
        }
        //
        //

        //Vyhledávání souborů pro dešifrování
        private void btnSeach1D_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.Multiselect = false;
            if (od.ShowDialog() == DialogResult.OK)
            {
                path1DTXT.Text = od.FileName;
            }
        }

        private void btnSeach2D_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                path2DTXT.Text = dialog.SelectedPath;
            }
        }
        //
        //

        
        //Možnost zvolit si koncovku
        private void koncovky_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckKoncovky.Checked)
            {
                KoncovkaTxt.Show();
                KoncovkaLabel.Show();
            }
            if (!CheckKoncovky.Checked)
            {
                KoncovkaTxt.Hide();
                KoncovkaLabel.Hide();
                
            }
        }
       //
       //
       
        //Šifrování souboru
        private void btnENC1_Click(object sender, EventArgs e)
        {
            
            try
            {
                TripleDES tDes = new TripleDES(pass1TXT.Text);
                tDes.EncryptFile(path1TXT.Text);
                uspech = true;
                if (CheckKoncovky.Checked)
                {
                    try
                    {
                        Directory.Move(path1TXT.Text, path1TXT.Text + "." + KoncovkaTxt.Text);
                        uspech = true;
                    }
                    catch (Exception)
                    {
                        uspech = false;
                    }
                   
                }

                
            }
            catch (Exception)
            {
                uspech = false;
            }

            if (uspech == true)
            {
                MessageBox.Show("Soubory se podařilo úspěšně zašifrovat!");
            }
            if (uspech == false)
            {
                MessageBox.Show("Někde nastala chyba..");
            }
            uspech = false;

        }
        //
        //

        //Dešifrování souboru
        private void btnDEC1_Click(object sender, EventArgs e)
        {
            try
            {
                TripleDES tDes = new TripleDES(pass1DTXT.Text);
                tDes.DecryptFile(path1DTXT.Text);
                uspech = true;

                if (CheckKoncovky.Checked)
                {
                    try
                    {
                        string strFirst;
                        int Count = 0;

                        strFirst = KoncovkaTxt.Text;

                        foreach (char chr in strFirst)
                        {
                            Count++;
                        }
                        int c = Count;
                        Directory.Move(path1DTXT.Text, path1DTXT.Text.Remove(path1DTXT.Text.Length - c));
                        uspech = true;
                    }
                    catch (Exception)
                    {
                        uspech = false;
                    }
                    
                }
              
            }
            catch (Exception)
            {
                uspech = false;
            }

            if (uspech == true)
            {
                MessageBox.Show("Soubory se podařilo úspěšně dešifrovat!");
            }
            if (uspech == false)
            {
                MessageBox.Show("Někde nastala chyba..");
            }
            uspech = false;

        }
        //
        //

        //Šifrování souborů
        private void btnENC2_Click(object sender, EventArgs e)
        {
            if (CheckSubDirectory.Checked)
            {
                uspech = true;

                try
                {
                    string path = (path2TXT.Text);

                    string[] list = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);

                    foreach (string name_x in list)
                    {
                        try
                        {
                            TripleDES tDES = new TripleDES(pass2TXT.Text);
                            tDES.EncryptFile(name_x);

                            if (CheckKoncovky.Checked)
                            {
                                Directory.Move(name_x, name_x + "." + KoncovkaTxt.Text);
                            }
                            uspech = true;
                            

                        }
                        catch 
                        {
                            uspech = false;
                        }


                    }

                    if (uspech = true)
                    {
                        MessageBox.Show("Soubory se podařilo úspěšně zašifrovat!");
                    }
                }
                catch (Exception)
                {
                    uspech = false;
                }

            }
            

            else
            {



                try
                {
                    string[] filePaths = Directory.GetFiles(path2TXT.Text);

                    foreach (string filep in filePaths)
                    {
                        try
                        {
                            TripleDES tDES = new TripleDES(pass2TXT.Text);
                            tDES.EncryptFile(filep);

                            if (CheckKoncovky.Checked)
                            {
                                Directory.Move(filep, filep + "." + KoncovkaTxt.Text);
                            }

                            uspech = true;
                        }

                        catch (Exception)
                        {
                           uspech= false;
                        }
                    }
                }
                catch (Exception)
                {
                    uspech = false;
                }

                if (uspech == true)
                {
                    MessageBox.Show("Soubory se podařilo úspěšně zašifrovat!");
                }
                if (uspech == false)
                {
                    MessageBox.Show("Někde nastala chyba..");
                }
                uspech = false;

            }
        }
        //
        //


        //Dešifrování suborů
        private void btnDEC2_Click(object sender, EventArgs e)
        {
            uspech = true;

            if (CheckSubDirectory.Checked)
            {
               

                try
                {
                    string path = (path2DTXT.Text);

                    string[] list = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);

                    foreach (string name_x in list)
                    {
                        try
                        {
                            TripleDES tDES = new TripleDES(pass2DTXT.Text);
                            tDES.DecryptFile(name_x);

                            if (CheckKoncovky.Checked)
                            {
                                try
                                {
                                    string strFirst;
                                    int Count = 0;

                                    strFirst = KoncovkaTxt.Text;

                                    foreach (char chr in strFirst)
                                    {
                                        Count++;
                                    }
                                    int c = Count;
                                    Directory.Move(name_x, name_x.Remove(name_x.Length - c));
                                }
                                catch {
                                    MessageBox.Show("Koncovku se nepovedlo odebrat");
                                }

                                uspech = true;


                            }
                        }
                        catch
                        {
                            uspech=false;
                        }
                       

                    }
                    if (uspech = true)
                    {
                        MessageBox.Show("Soubory se úspěšně podařilo dešifrovat!");
                    }
                }
                catch (Exception)
                {
                    uspech = false;
                }
                if (uspech == false)
                {
                    MessageBox.Show("Někde nastala chyba..");
                    uspech= false;
                }

            }
            else
            {



                try
                {
                    string[] filePaths = Directory.GetFiles(path2DTXT.Text);

                    foreach (string filep in filePaths)
                    {
                        try
                        {
                            TripleDES tDES = new TripleDES(pass2DTXT.Text);
                            tDES.DecryptFile(filep);

                            if (CheckKoncovky.Checked)
                            {
                                try
                                {
                                    string strFirst;
                                    int Count = 0;

                                    strFirst = KoncovkaTxt.Text;

                                    foreach (char chr in strFirst)
                                    {
                                        Count++;
                                    }
                                    int c = Count;
                                    Directory.Move(filep, filep.Remove(filep.Length - c));

                                    uspech = true;
                                }
                                catch
                                {
                                    uspech = false;
                                }

                                uspech = true;
                            }
                        }
                        catch (Exception)
                        {

                        }
                       
                    }
                }
                catch (Exception)
                {
                    uspech = false;
                }

                if (uspech == true)
                {
                    MessageBox.Show("Soubory se podařilo úspěšně dešifrovat!");
                }
                if (uspech == false)
                {
                    MessageBox.Show("Někde nastala chyba..");
                }
                uspech = false;
            }
        }
        //
        //

       
        
        //
        //
    }
}
