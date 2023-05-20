/**
 * Temat: Color pop
 * Roman Gawenda semestr 5 2022/2023
 * GUI, manager wątków oraz główne funkcjonalności
*/

using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Image = System.Drawing.Image;
using System.Diagnostics;
using File = System.IO.File;
using CsharpDll;

namespace Projekt_JA
{
    public partial class Window : Form
    {
        public Window()
        {
            InitializeComponent();
        }

        //load window
        private void Window_Load(object sender, EventArgs e)
        {
            this.ThreadTrackBar.Value = Environment.ProcessorCount;
            this.label1.Text = Environment.ProcessorCount.ToString();
            numericUpDown1.Controls.RemoveAt(0);
            numericUpDown2.Controls.RemoveAt(0);
            numericUpDown3.Controls.RemoveAt(0);
            numericUpDown4.Controls.RemoveAt(0);
            numericUpDown5.Controls.RemoveAt(0);
            numericUpDown6.Controls.RemoveAt(0);
        }

        //import masm library
        [DllImport(@"C:\Users\Roman\source\Projekt_JA\Projekt_JA\x64\Debug\AsmDll.dll")]


        static extern int MakeGrayA(byte[] tab_1, byte[] tab_2, byte[] wynik);

        public static void GrayscaleC_Sharp(byte[] tab_red, byte[] tab_green, byte[] tab_blue, ref byte[] gray)
        {
            GrayCsharp.MakeGrayC(tab_red,
                        tab_green,
                        tab_blue);
            gray = (byte[])tab_red.Clone();
        }

        public static void GrayscaleAsm(byte[] tab_red, byte[] tab_green, byte[] tab_blue, ref byte[] gray)
        {
            MakeGrayA(tab_red, tab_green, tab_blue);
            gray = (byte[])tab_red.Clone();
        }

        public Bitmap MakeGrayscale(Bitmap original, int max_threads, byte library, ref long time)
        {
            Bitmap new_bitmap = new Bitmap(original.Width, original.Height);

            bool[,] isChange = new bool[original.Width, original.Height];

            //data preparation
            byte[] tab_red = new byte[8];
            byte[] tab_green = new byte[8];
            byte[] tab_blue = new byte[8];

            int lenght;
            if (original.Width * original.Height % 8 == 0)
            {
                lenght = original.Width * original.Height / 8;
            }
            else
            {
                lenght = original.Width * original.Height / 8 + 1;
            }
            

            byte[][] t_red = new byte[lenght][];
            byte[][] t_green = new byte[lenght][];
            byte[][] t_blue = new byte[lenght][];
            byte[][] t_grayscale = new byte[lenght][];

            int i = 0;
            int ii = 0;
            for (int x = 0; x < original.Width; x++)
            {
                for (int y = 0; y < original.Height; y++)
                {   
                    Color oc = original.GetPixel(x, y);
                    
                    if (!(numericUpDown1.Value <= oc.R && oc.R < numericUpDown4.Value && numericUpDown2.Value <= oc.G && oc.G < numericUpDown5.Value && numericUpDown3.Value <= oc.B && oc.B < numericUpDown6.Value))
                    {
                        if (i > 7)
                        {
                            i = 0;
                            t_red[ii] = (byte[])tab_red.Clone();
                            t_green[ii] = (byte[])tab_green.Clone();
                            t_blue[ii] = (byte[])tab_blue.Clone();
                            ii++;
                        }
                        
                        tab_red[i] = oc.R;
                        tab_green[i] = oc.G;
                        tab_blue[i] = oc.B;

                        i++;
                        isChange[x, y] = true;
                    }
                    else
                    {
                        isChange[x,y] = false;
                        new_bitmap.SetPixel(x, y, oc);
                    }
                    if (x == original.Width - 1 && y == original.Height - 1)
                    {
                        t_red[ii] = (byte[])tab_red.Clone();
                        t_green[ii] = (byte[])tab_green.Clone();
                        t_blue[ii] = (byte[])tab_blue.Clone();
                    }
                }
                    
            }
            
            
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            if(!(ii==0))
            {
              
                var t1 = Task.Run(() => {
                    if (library == 0)
                    {

                        Parallel.For(0, ii+1, new ParallelOptions { MaxDegreeOfParallelism = max_threads },
                        x => { GrayscaleC_Sharp(t_red[x], t_green[x], t_blue[x], ref t_grayscale[x]); });

                    }
                    else if (library == 1)
                    {

                        Parallel.For(0, ii+1, new ParallelOptions { MaxDegreeOfParallelism = max_threads },
                        x => { GrayscaleAsm(t_red[x], t_green[x], t_blue[x], ref t_grayscale[x]); });

                    }
                });
                Task.WaitAll(t1);
            }
            


            
            stopwatch.Stop();
            time = (stopwatch.ElapsedTicks/(TimeSpan.TicksPerMillisecond/1000));

            label5.Text = (stopwatch.ElapsedTicks / (TimeSpan.TicksPerMillisecond / 1000)).ToString();
            int j = 0;
            int k = 0;
            //create new bitmap
            
            for (int x = 0; x < original.Width; x++)
            {
                for (int y = 0; y < original.Height; y++)
                {
                    if(j>7)
                    {
                        j = 0;
                        k++;
                    }

                    
                    if (isChange[x,y])
                    {
                       
                            byte grayScale = (byte)t_grayscale[k][j];

                            Color nc = Color.FromArgb(grayScale, grayScale, grayScale);
                            new_bitmap.SetPixel(x, y, nc);
                        
                        
                        j++;

                    }
                    
                    
                }
            }
            
            return new_bitmap;
        }

        private Bitmap MyImage;

        //Save button
        private void Save_Button_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "bmp files (*.bmp)|*.bmp";
            saveFileDialog1.Title = "Save an Image File";
           
            
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string ext = System.IO.Path.GetExtension(saveFileDialog1.FileName);

                ConvertedPictureBox.Image.Save(saveFileDialog1.FileName, ImageFormat.Bmp);

            }
        }
        //Import button
        private void Import_Button_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;
            
            this.openFileDialog1.InitialDirectory = "c:\\";
            this.openFileDialog1.Filter = "bmp files (*.bmp)|*.bmp";
            

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                filePath = openFileDialog1.FileName;

                //Read the contents of the file into a stream
                var fileStream = openFileDialog1.OpenFile();

                using (StreamReader reader = new StreamReader(fileStream))
                {
                    fileContent = reader.ReadToEnd();
                    
                    if (MyImage != null)
                    {
                        MyImage.Dispose();
                    }

                    // Stretches the image to fit the pictureBox.
                    ImportPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    
                    MyImage = new Bitmap(filePath);
                    //ImportPictureBox.ClientSize = new Size(xSize, ySize);
                    ImportPictureBox.Image = (Image)MyImage;
                }
            }
        }
        
        //Start button
        private void Start_Button_Click(object sender, EventArgs e)
        {
            
            if(MyImage != null)
            {
                

                if (TestOption.Checked == true)
                {
                    string[] execute_time = new string[14];
                    long[] e_time = new long[14];
                    long time2 = new long();

                    int threads = 1;
                    for (int i = 0; i < 14; i+=2)
                    {
                        for(int j = 0; j<100; j++)
                        {
                            MakeGrayscale(MyImage, threads, 0, ref time2);
                            e_time[i] += time2;
                            MakeGrayscale(MyImage, threads, 1, ref time2);
                            e_time[i + 1] += time2;
                        }
                        e_time[i] = e_time[i] / 100;
                        e_time[i+1] = e_time[i+1] / 100;
                        threads = threads * 2;
                    }
                    threads = 1;
                    for (int i = 0; i < 14; i += 2)
                    {
                        execute_time[i] = e_time[i].ToString() + ";  C# ;" + threads + ";";

                        execute_time[i+1] = e_time[i + 1].ToString() + ";  ASM ;" + threads + ";";
                        threads = threads * 2;
                    }
                    using (StreamWriter sw = File.CreateText("results.txt"))
                    {
                        foreach (String value in execute_time)
                        {
                            sw.WriteLine(value);
                        }
                    }

                }
                else
                {
                    byte library = 0;
                    if (CSharpLibrary.Checked == true)
                    {
                        library = 0;
                    }
                    else if (ASMLibrary.Checked == true)
                    {
                        library = 1;
                    }
                    long time = new long();
                    int max_threads = this.ThreadTrackBar.Value;
                    Bitmap ConvertImage = MakeGrayscale(MyImage, max_threads, library, ref time);
                    ConvertedPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    ConvertedPictureBox.Image = ConvertImage;
                }
            }
        }


        private void ThreadTrackBar_Scroll(object sender, EventArgs e)
        {
            this.label1.Text = this.ThreadTrackBar.Value.ToString();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
             if(numericUpDown4.Value < numericUpDown1.Value)
            {
                numericUpDown1.Value = numericUpDown4.Value;
            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown5.Value < numericUpDown2.Value)
            {
                numericUpDown2.Value = numericUpDown5.Value;
            }
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown6.Value < numericUpDown3.Value)
            {
                numericUpDown3.Value = numericUpDown6.Value;
            }
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown4.Value < numericUpDown1.Value)
            {
                numericUpDown4.Value = numericUpDown1.Value;
            }
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown5.Value < numericUpDown2.Value)
            {
                numericUpDown5.Value = numericUpDown2.Value;
            }
        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown6.Value < numericUpDown3.Value)
            {
                numericUpDown6.Value = numericUpDown3.Value;
            }
        }
    }
}
