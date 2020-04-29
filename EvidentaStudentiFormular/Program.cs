using System.Windows.Forms;
using System.Drawing;
using NivelAccesDate;
using EvidentaStudenti;
using LibrarieModele;
using System;

namespace EvidentaStudentiFormular
{
    class Program
    {
        static void Main(string[] args)
        {
            FormularMasini formular = new FormularMasini();
            formular.Show();
            Application.Run();
        }
    }

    public class FormularMasini : Form
    {
        IStocareData adminMasini = StocareFactory.GetAdministratorStocare();

        private const int LATIME_CONTROL = 150; //in px
        private const int INALTIME_CONTROL = 20; //in px
        private const int DIMENSIUNE_PAS_Y = 30;
        private const int DIMENSIUNE_PAS_X = 170;
        private const int LUNGIME_MIN = 1;
        private const int LUNGIME_MAX = 15;
        private static int ID = 1;

        private Label LabelMarca;
        private TextBox TextMarca;

        private Label LabelModel;
        private TextBox TextModel;

        private Label LabelPret;
        private TextBox TextPret;

        private Label LabelAnF;
        private TextBox TextAnF;

        private Label LabelPutere;
        private TextBox TextPutere;

        private Label LabelCuloare;
        private TextBox TextCuloare;

        private Label LabelCutie;
        private TextBox TextCutie;

        private Button ButtonAdauga;
        private Label LabelInfoMasina;

        private Button ButtonClear;

        private PictureBox Imagine;

        public FormularMasini()
        {
            this.Size = new System.Drawing.Size(500, 850);
            this.MaximumSize = new System.Drawing.Size(500, 850);
            this.MinimumSize = new System.Drawing.Size(500, 850);
            this.Font = new Font("Arial", 10, FontStyle.Bold);
            this.ForeColor = Color.White;
            this.Text = " Evidenta Masini";
            this.MaximizeBox = false;
            //Marca
            LabelMarca = new Label();
            LabelMarca.Width = LATIME_CONTROL;
            LabelMarca.Height = INALTIME_CONTROL;
            LabelMarca.Location = new System.Drawing.Point(0, 10);
            LabelMarca.Text = "Marca";
            LabelMarca.BackColor = Color.Black;
            Controls.Add(LabelMarca);

            TextMarca = new TextBox();
            TextMarca.Width = LATIME_CONTROL;
            TextMarca.Location = new System.Drawing.Point(300, 10);
            Controls.Add(TextMarca);

            //Model
            LabelModel = new Label();
            LabelModel.Width = LATIME_CONTROL;
            LabelModel.Height = INALTIME_CONTROL;
            LabelModel.Location = new System.Drawing.Point(0, 50);
            LabelModel.Text = "Model";
            LabelModel.BackColor = Color.Black;
            Controls.Add(LabelModel);

            TextModel = new TextBox();
            TextModel.Width = LATIME_CONTROL;
            TextModel.Location = new System.Drawing.Point(300, 50);
            Controls.Add(TextModel);

            //Pret
            LabelPret = new Label();
            LabelPret.Width = LATIME_CONTROL;
            LabelPret.Height = INALTIME_CONTROL;
            LabelPret.Location = new System.Drawing.Point(0, 90);
            LabelPret.Text = "Pret";
            LabelPret.BackColor = Color.Black;
            Controls.Add(LabelPret);


            TextPret = new TextBox();
            TextPret.Width = LATIME_CONTROL;
            TextPret.Location = new System.Drawing.Point(300, 90);
            Controls.Add(TextPret);

            //AnF
            LabelAnF = new Label();
            LabelAnF.Width = LATIME_CONTROL;
            LabelAnF.Height = INALTIME_CONTROL;
            LabelAnF.Location = new System.Drawing.Point(0, 130);
            LabelAnF.Text = "An fabricatie";
            LabelAnF.BackColor = Color.Black;
            Controls.Add(LabelAnF);


            TextAnF = new TextBox();
            TextAnF.Width = LATIME_CONTROL;
            TextAnF.Location = new System.Drawing.Point(300, 130);
            Controls.Add(TextAnF);

            //Putere
            LabelPutere = new Label();
            LabelPutere.Width = LATIME_CONTROL;
            LabelPutere.Height = INALTIME_CONTROL;
            LabelPutere.Location = new System.Drawing.Point(0, 170);
            LabelPutere.Text = "Putere(CP)";
            LabelPutere.BackColor = Color.Black;
            Controls.Add(LabelPutere);


            TextPutere = new TextBox();
            TextPutere.Width = LATIME_CONTROL;
            TextPutere.Location = new System.Drawing.Point(300, 170);
            Controls.Add(TextPutere);


            //Culoare
            LabelCuloare = new Label();
            LabelCuloare.Width = LATIME_CONTROL;
            LabelCuloare.Height = INALTIME_CONTROL;
            LabelCuloare.Location = new System.Drawing.Point(0, 210);
            LabelCuloare.Text = "Culoare";
            LabelCuloare.BackColor = Color.Black;
            Controls.Add(LabelCuloare);


            TextCuloare = new TextBox();
            TextCuloare.Width = LATIME_CONTROL;
            TextCuloare.Location = new System.Drawing.Point(300, 210);
            Controls.Add(TextCuloare);

            //Cutie
            LabelCutie = new Label();
            LabelCutie.Width = LATIME_CONTROL;
            LabelCutie.Height = INALTIME_CONTROL;
            LabelCutie.Location = new System.Drawing.Point(0, 250);
            LabelCutie.Text = "Cutie viteze";
            LabelCutie.BackColor = Color.Black;
            Controls.Add(LabelCutie);


            TextCutie = new TextBox();
            TextCutie.Width = LATIME_CONTROL;
            TextCutie.Location = new System.Drawing.Point(300, 250);
            Controls.Add(TextCutie);

            //butonAdd
            ButtonAdauga = new Button();
            ButtonAdauga.Width = 2*LATIME_CONTROL;
            ButtonAdauga.BackColor = Color.Brown;
            ButtonAdauga.Location = new System.Drawing.Point(90, 290);
            ButtonAdauga.Text = "Adauga";
            ButtonAdauga.Click += OnButtonAdaugaClicked;
            Controls.Add(ButtonAdauga);

            //InfoStud
            LabelInfoMasina = new Label();
            LabelInfoMasina.Width = 3*LATIME_CONTROL;
            LabelInfoMasina.Height = 13*INALTIME_CONTROL;
            LabelInfoMasina.Location = new System.Drawing.Point(17, 370);
            LabelInfoMasina.Text = "INFORMATII MASINI:";
            LabelInfoMasina.BackColor = Color.Black;
            Controls.Add(LabelInfoMasina);

            //butonClear
            ButtonClear = new Button();
            ButtonClear.Width =  LATIME_CONTROL;
            ButtonClear.BackColor = Color.Blue;
            ButtonClear.Location = new System.Drawing.Point(170,330);
            ButtonClear.Text = "Sterge date";
            ButtonClear.Click += OnButtonSterge;
            Controls.Add(ButtonClear);


            //Imagine
            Imagine = new PictureBox();
            Imagine.SizeMode = PictureBoxSizeMode.Zoom;
            Imagine.Width =  2*LATIME_CONTROL;
            Imagine.Height = 2*LATIME_CONTROL;
            Imagine.BackColor = Color.Transparent;
            Imagine.Location = new System.Drawing.Point(67, 560);
            Imagine.Image = Image.FromFile("C:/Users/Andrei/Desktop/car.gif");
            
            Controls.Add(Imagine);



        }
        private void OnButtonAdaugaClicked(object sender, System.EventArgs e)
        {
            //obiectul *sender* este butonul btnCalculeaza
            //*e* reprezinta o lista de valori care se transmit la invocarea evenimentului Click al clasei Button catre subscriber-ul curent care este forma FormularGeometrie 

            //Int32.TryParse();
            //Int32.TryParse(txtLungime.Text, out lung);
            LabelMarca.ForeColor = Color.White;
            LabelModel.ForeColor = Color.White;
            LabelPret.ForeColor = Color.White;
            LabelCuloare.ForeColor = Color.White;
            LabelCutie.ForeColor = Color.White;
            LabelAnF.ForeColor = Color.White;
            LabelPutere.ForeColor = Color.White;
            // LabelNote.ForeColor = Color.White;

            if (TextMarca.Text.Length >= LUNGIME_MIN && TextMarca.Text.Length <= LUNGIME_MAX && TextModel.Text.Length >= LUNGIME_MIN && TextModel.Text.Length <= LUNGIME_MAX && TextPret.Text.Length >= LUNGIME_MIN && TextPret.Text.Length <= LUNGIME_MAX && TextAnF.Text.Length >= LUNGIME_MIN && TextAnF.Text.Length <= LUNGIME_MAX && TextPutere.Text.Length >= LUNGIME_MIN && TextPutere.Text.Length <= LUNGIME_MAX && TextCuloare.Text.Length >= LUNGIME_MIN && TextCuloare.Text.Length <= LUNGIME_MAX)
             {

                 Masina m = new Masina(TextMarca.Text, TextModel.Text, System.Convert.ToInt64(TextPret.Text), System.Convert.ToInt32(TextAnF.Text), System.Convert.ToInt32(TextPutere.Text),TextCutie.Text);
                 m.Culoare = (Culori)Enum.Parse(typeof(Culori), TextCuloare.Text, true);
                 Random rnd = new Random();

                    for (int j = 0; j < rnd.Next(1, 6); j++)
                    {
                        var op = (Optiuni)rnd.Next(1, 32);
                        m.Optiune = m.Optiune | op;
                    }

                ButtonAdauga.ForeColor = Color.LimeGreen;
                 
                 LabelInfoMasina.Text = LabelInfoMasina.Text + "\n" + ID + m.ConversieLaSirFisier2();
                ID++;
                 adminMasini.AddMasina(m);
             }
             if(TextMarca.Text.Length==0)
             {
                 LabelMarca.ForeColor = Color.Red;
             }
             if (TextModel.Text.Length == 0)
             {
                 LabelModel.ForeColor = Color.Red;
             }
             if (TextPret.Text.Length == 0)
             {
                 LabelPret.ForeColor = Color.Red;
             }
             if (TextAnF.Text.Length == 0)
             {
                LabelAnF.ForeColor = Color.Red;
             }
             if (TextPutere.Text.Length == 0)
             {
                LabelPutere.ForeColor = Color.Red;
             }
             if (TextCuloare.Text.Length == 0)
             {
                LabelCuloare.ForeColor = Color.Red;
             }
             if (TextCutie.Text.Length == 0)
             {
                LabelCutie.ForeColor = Color.Red;
             }



        }
         

         private void OnButtonSterge(object sender, System.EventArgs e)
         {

                 LabelInfoMasina.Text = "";
                 TextCuloare.Text = "";
                 TextMarca.Text = "";
                 TextModel.Text= "";
                 TextPutere.Text = string.Empty;
                 TextAnF.Text = string.Empty;
                 TextPret.Text = string.Empty;
                 TextCutie.Text = string.Empty;
                 //LabelInfoStudent.Text = "";
             }  
             
         } 

   }


    

