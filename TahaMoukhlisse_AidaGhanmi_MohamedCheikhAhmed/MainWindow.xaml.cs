using System;
using System.Collections.Generic;
using System.Linq;
using System.Printing;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TahaMoukhlisse_AidaGhanmi_MohamedCheikhAhmed
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string? premierNumero;
        private bool isModuloClicked = false;
        private bool isMultiplicationClicked = false;
        private bool isDivisionClicked = false;
        private bool isSoustractionClicked = false;
        private bool isAdditionClicked = false;
        public MainWindow()
        {
            InitializeComponent();

            SupprimerButton.Click += SupprimerButton_Click;
            OffButton.Click += OffButton_Click;
            HelpButton.Click += HelpButton_Click;
            InverseButton.Click += InverseButton_Click;
            ModuloButton.Click += ModuloButton_Click;
            EqualButton.Click += EqualButton_Click;
            FactorielButton.Click += FactorielButton_Click;
            MultiplicationButton.Click += MultiplicationButton_Click;
            DivisionButton.Click += DivisionButton_Click;
            MoinsButton.Click += MoinsButton_Click;
            AdditionButton.Click += AdditionButton_Click;

            ZeroButton.Click += ZeroButton_Click;
            OneButton.Click += OneButton_Click;
            TwoButton.Click += TwoButton_Click;
            ThreeButton.Click += ThreeButton_Click;
            FourButton.Click += FourButton_Click;
            FiveButton.Click += FiveButton_Click;
            SixButton.Click += SixButton_Click;
            SevenButton.Click += SevenButton_Click;
            EightButton.Click += EightButton_Click;
            NineButton.Click += NineButton_Click;
            PointButton.Click += PointButton_Click;
        } 
        /// <summary>
        /// Declaration des methodes pour assigner une valeur au champ input selon le chiffre clique
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ZeroButton_Click(object sender, RoutedEventArgs e)
        {
            InputBox.Text += "0";
        }
        private void OneButton_Click(object sender, RoutedEventArgs e)
        {
                InputBox.Text += "1"; 
        }
        private void TwoButton_Click(object sender, RoutedEventArgs e)
        {       
                InputBox.Text += "2";
        }
        private void ThreeButton_Click(object sender, RoutedEventArgs e)
        {
            InputBox.Text += "3";
        }
        private void FourButton_Click(object sender, EventArgs e)
        {
            InputBox.Text += "4";
        }
        private void FiveButton_Click(object sender, EventArgs e)
        {
            InputBox.Text += "5";
        }
        private void SixButton_Click(object sender, EventArgs e)
        {
            InputBox.Text += "6";
        }
        private void SevenButton_Click(object sender, EventArgs e)
        {
            InputBox.Text += "7";
        }
        private void EightButton_Click(object sender, EventArgs e)
        {
            InputBox.Text += "8";
        }
        private void NineButton_Click(object sender, EventArgs e)
        {
            InputBox.Text += "9";
        }
        private void PointButton_Click(object sender, RoutedEventArgs e)
        {
                InputBox.Text += ".";
        }

        // reinitialiser les valeurs du textbox et textblock a un string vide
        private void SupprimerButton_Click(object sender, RoutedEventArgs e)
        {
            ResultatBox.Text= string.Empty;
            InputBox.Text = string.Empty;
        }
        // arrete l'activite en cours en cliquant sur le bouton OFF
        private void OffButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        //Methode pour ouvrir la fenetre aide en cliquant sur ?
        private void HelpButton_Click(object sender, RoutedEventArgs e)
        {     
            HelpWindow helpWindow = new();
            helpWindow.Show();
        }
        // Methode pour calculer l'inverse d'un chiffre indique
        private void InverseButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //recupere le input de l'utilisateur puis met l'operation de le ResultatBox puis met le resultat dans InputBox
                double input = Convert.ToDouble(InputBox.Text);
                double result = 1 / input;
                InputBox.Text = result.ToString();
                ResultatBox.Text = "1 / " + input;
            }
            // Exception au cas ou l'utilisateur rajoute du texte au lieu d'un chiffre
            catch (Exception)
            {
                MessageBox.Show("Entrez une valeur numérique valide.");
                InputBox.Clear();
                ResultatBox.Text= string.Empty;
            }
        }
        // Calcule le modulo de deux chiffres en cliquant sur %
        private void ModuloButton_Click(object sender, RoutedEventArgs e)
        {
            premierNumero = InputBox.Text;
            ResultatBox.Text = premierNumero + "%";
            isModuloClicked = true;
            InputBox.Clear();
        }
        /// <summary>
        /// Methodes pour recuperer le premier numero, le met dans le resultatBox et verifie la condition Boolean
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
       
        // Methode pour la multiplication
        private void MultiplicationButton_Click(object sender, RoutedEventArgs e)
        {
            premierNumero = InputBox.Text;
            ResultatBox.Text = premierNumero + "x";
            isMultiplicationClicked = true;
            InputBox.Clear();

        }
        // Methode pour la division
        private void DivisionButton_Click(object sender, RoutedEventArgs e)
        {
            premierNumero = InputBox.Text;
            ResultatBox.Text = premierNumero + "/";
            isDivisionClicked = true;
            InputBox.Clear();
        }
        // Methode pour la Soustraction
        private void MoinsButton_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(InputBox.Text))
            {
                premierNumero = InputBox.Text;
                ResultatBox.Text = premierNumero + "-";
                isSoustractionClicked = true;
                InputBox.Clear();
            }
        }
        //Methode pour l'addition
        private void AdditionButton_Click (object sender, RoutedEventArgs e)
        {
            premierNumero = InputBox.Text;
            ResultatBox.Text = premierNumero + "+";
            isAdditionClicked = true;
            InputBox.Clear();
        }
        // Methode pour le Factoriel
        private void FactorielButton_Click(object sender, RoutedEventArgs e)
        {
            if (!double.TryParse(InputBox.Text, out double num))
            {
                ResultatBox.Text = "Veuillez entrer un chiffre valide";
                return;
            }
            double result = 1;
            for (int i = 1; i <= num; i++)
            {
                result *= i;
            }
            ResultatBox.Text = $"{num}!";
            InputBox.Text = result.ToString();
        }
    // Bouton Egal
    private void EqualButton_Click(object sender, RoutedEventArgs e)
    {
            if (isModuloClicked)
            {
                // Convertis les valeurs de premierNumero et InputBox.Text en double
                double num1 = double.Parse(premierNumero);
                double num2 = double.Parse(InputBox.Text);
                // effectue l'operation modulo des deux chiffres fournis
                double resultat = num1 % num2;
                ResultatBox.Text = num1 + "%" + num2;
                InputBox.Text = resultat.ToString();
                isModuloClicked = false;
            }
            if (isMultiplicationClicked)
            {
                // Convertis les valeurs de premierNumero et InputBox.Text en double
                double num1 = double.Parse(premierNumero);
                double num2 = double.Parse(InputBox.Text);
                // effectue l'operation multiplication des deux chiffres fournis
                double resultat = num1 * num2;
                ResultatBox.Text = num1 + "x" + num2;
                InputBox.Text = resultat.ToString();
                isMultiplicationClicked = false;
            }
            if (isDivisionClicked)
            {
                // Convertis les valeurs de premierNumero et InputBox.Text en double
                double num1 = double.Parse(premierNumero);
                double num2 = double.Parse(InputBox.Text);
                // effectue l'operation division des deux chiffres fournis
                double resultat = num1 / num2;
                ResultatBox.Text = num1 + "/" + num2;
                InputBox.Text = resultat.ToString();
                isDivisionClicked = false;

            }
            if (isSoustractionClicked)
            {
                // Convertis les valeurs de premierNumero et InputBox.Text en double
                double num1 = double.Parse(premierNumero);
                double num2 = double.Parse(InputBox.Text);
                // calcul de la difference entre les deux chiffres fournis
                double resultat = num1 - num2;
                ResultatBox.Text = num1 + "-" + num2;
                InputBox.Text = resultat.ToString();
                isSoustractionClicked = false;
            }
           if (isAdditionClicked)
            {
                // Convertis les valeurs de premierNumero et InputBox.Text en double
                double num1 = double.Parse(premierNumero);
                double num2 = double.Parse(InputBox.Text);
                // calcul de la difference entre les deux chiffres fournis
                double resultat = num1 + num2;
                ResultatBox.Text = num1 + "+" + num2;
                InputBox.Text = resultat.ToString();
                isAdditionClicked = false;
            }
            else
            {
                ResultatBox.Text = ResultatBox.Text;
            }
        }
}
}
