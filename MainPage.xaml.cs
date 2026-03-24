using System;
using Microsoft.Maui.Controls;

namespace MauiAppjogodavelha
{
    public partial class MainPage : ContentPage
    {
        string vez = "X";

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.IsEnabled = false;
            btn.Text = vez;

            vez = (vez == "X") ? "O" : "X";

            VerificarVitoria();
        }

        void VerificarVitoria()
        {
            if (btn10.Text == "X" && btn11.Text == "X" && btn12.Text == "X")
            {
                DisplayAlert("Parabéns!", "X venceu!", "OK");
                Zerar();
                return;
            }

            if (btn20.Text == "X" && btn21.Text == "X" && btn22.Text == "X")
            {
                DisplayAlert("Parabéns!", "X venceu!", "OK");
                Zerar();
                return;
            }

            // Linha 3
            if (btn30.Text == "X" && btn31.Text == "X" && btn32.Text == "X")
            {
                DisplayAlert("Parabéns!", "X venceu!", "OK");
                Zerar();
                return;
            }

            // Coluna 1
            if (btn10.Text == "X" && btn20.Text == "X" && btn30.Text == "X")
            {
                DisplayAlert("Parabéns!", "X venceu!", "OK");
                Zerar();
                return;
            }

            // Coluna 2
            if (btn11.Text == "X" && btn21.Text == "X" && btn31.Text == "X")
            {
                DisplayAlert("Parabéns!", "X venceu!", "OK");
                Zerar();
                return;
            }

            // Coluna 3
            if (btn12.Text == "X" && btn22.Text == "X" && btn32.Text == "X")
            {
                DisplayAlert("Parabéns!", "X venceu!", "OK");
                Zerar();
                return;
            }

            // Diagonal 1
            if (btn10.Text == "X" && btn21.Text == "X" && btn32.Text == "X")
            {
                DisplayAlert("Parabéns!", "X venceu!", "OK");
                Zerar();
                return;
            }

            // Diagonal 2
            if (btn12.Text == "X" && btn21.Text == "X" && btn30.Text == "X")
            {
                DisplayAlert("Parabéns!", "X venceu!", "OK");
                Zerar();
                return;
            }

            // Agora repetir para “O”
            if (btn10.Text == "O" && btn11.Text == "O" && btn12.Text == "O")
            {
                DisplayAlert("Parabéns!", "O venceu!", "OK");
                Zerar();
                return;
            }
            if (btn20.Text == "O" && btn21.Text == "O" && btn22.Text == "O")
            {
                DisplayAlert("Parabéns!", "O venceu!", "OK");
                Zerar();
                return;
            }
            if (btn30.Text == "O" && btn31.Text == "O" && btn32.Text == "O")
            {
                DisplayAlert("Parabéns!", "O venceu!", "OK");
                Zerar();
                return;
            }
            if (btn10.Text == "O" && btn20.Text == "O" && btn30.Text == "O")
            {
                DisplayAlert("Parabéns!", "O venceu!", "OK");
                Zerar();
                return;
            }
            if (btn11.Text == "O" && btn21.Text == "O" && btn31.Text == "O")
            {
                DisplayAlert("Parabéns!", "O venceu!", "OK");
                Zerar();
                return;
            }
            if (btn12.Text == "O" && btn22.Text == "O" && btn32.Text == "O")
            {
                DisplayAlert("Parabéns!", "O venceu!", "OK");
                Zerar();
                return;
            }
            if (btn10.Text == "O" && btn21.Text == "O" && btn32.Text == "O")
            {
                DisplayAlert("Parabéns!", "O venceu!", "OK");
                Zerar();
                return;
            }
            if (btn12.Text == "O" && btn21.Text == "O" && btn30.Text == "O")
            {
                DisplayAlert("Parabéns!", "O venceu!", "OK");
                Zerar();
                return;
            }

            // Verifica empate (todos preenchidos e ninguém venceu)
            bool todosPreenchidos =
                !string.IsNullOrEmpty(btn10.Text) &&
                !string.IsNullOrEmpty(btn11.Text) &&
                !string.IsNullOrEmpty(btn12.Text) &&
                !string.IsNullOrEmpty(btn20.Text) &&
                !string.IsNullOrEmpty(btn21.Text) &&
                !string.IsNullOrEmpty(btn22.Text) &&
                !string.IsNullOrEmpty(btn30.Text) &&
                !string.IsNullOrEmpty(btn31.Text) &&
                !string.IsNullOrEmpty(btn32.Text);

            if (todosPreenchidos)
            {
                DisplayAlert("Empate", "Deu empate!", "OK");
                Zerar();
            }
        }

        void Zerar()
        {
            foreach (var btn in new[] { btn10, btn11, btn12, btn20, btn21, btn22, btn30, btn31, btn32 })
            {
                btn.Text = "";
                btn.IsEnabled = true;
            }
            vez = "X";
        }
    }
}
