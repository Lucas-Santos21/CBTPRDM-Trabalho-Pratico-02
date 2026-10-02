//Nome e prontuário da dupla:
//Lucas da Silva Santos CB3030598
//Kaueh Farias Ferreira dos Santos CB3031438

using System.Collections.ObjectModel;

namespace TarefasApp
{
    public partial class PaginaDetalhes : ContentPage
    {
        private Tarefa _tarefa;
        private ObservableCollection<Tarefa> _tarefas;

        public PaginaDetalhes(Tarefa tarefa, ObservableCollection<Tarefa> tarefas)
        {
            InitializeComponent();
            _tarefa = tarefa;
            _tarefas = tarefas;
            AtualizarInterface();
        }

        // Executado toda vez que a página volta a aparecer na tela (após o Modal de Edição ser fechado)
        protected override void OnAppearing()
        {
            base.OnAppearing();
            AtualizarInterface();
        }

        private void AtualizarInterface()
        {
            lblTitulo.Text = _tarefa.Titulo;
            lblDescricao.Text = _tarefa.Descricao;
            lblData.Text = _tarefa.DataCriacao.ToString("dd/MM/yyyy");
            lblPrioridade.Text = _tarefa.Prioridade;
        }

        private async void OnEditarClicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ModalEditar(_tarefa));
        }

        private async void OnExcluirClicked(object sender, EventArgs e)
        {
            bool confirmacao = await DisplayAlert("Confirmação", "Deseja realmente excluir esta tarefa?", "Sim", "Não");

            if (confirmacao)
            {
                _tarefas.Remove(_tarefa);
                await Navigation.PopAsync(); // Retorna para a MainPage após excluir
            }
        }
    }
}