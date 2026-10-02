//Nome e prontuário da dupla:
//Lucas da Silva Santos CB3030598
//Kaueh Farias Ferreira dos Santos CB3031438

using System.Collections.ObjectModel;

namespace TarefasApp
{
    public partial class ModalAdicionar : ContentPage
    {
        private ObservableCollection<Tarefa> _tarefas;

        public ModalAdicionar(ObservableCollection<Tarefa> tarefas)
        {
            InitializeComponent();
            _tarefas = tarefas;
            dpData.Date = DateTime.Now; // Data de hoje por padrão
        }

        private async void OnSalvarClicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitulo.Text))
            {
                await DisplayAlert("Atenção", "O título da tarefa é obrigatório.", "OK");
                return;
            }

            var novaTarefa = new Tarefa
            {
                Titulo = txtTitulo.Text,
                Descricao = txtDescricao.Text,
                DataCriacao = dpData.Date,
                Prioridade = pckPrioridade.SelectedItem?.ToString() ?? "Baixa"
            };

            // Adiciona na lista principal
            _tarefas.Add(novaTarefa);

            // Fecha o modal
            await Navigation.PopModalAsync();
        }

        private async void OnCancelarClicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}