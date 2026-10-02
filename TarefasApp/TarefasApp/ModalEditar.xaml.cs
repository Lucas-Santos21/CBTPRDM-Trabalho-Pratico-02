//Nome e prontuário da dupla:
//Lucas da Silva Santos CB3030598
//Kaueh Farias Ferreira dos Santos CB3031438

namespace TarefasApp
{
    public partial class ModalEditar : ContentPage
    {
        private Tarefa _tarefa;

        public ModalEditar(Tarefa tarefa)
        {
            InitializeComponent();
            _tarefa = tarefa;

            // Preenche os campos com os dados atuais da tarefa
            txtTitulo.Text = _tarefa.Titulo;
            txtDescricao.Text = _tarefa.Descricao;
            dpData.Date = _tarefa.DataCriacao;
            pckPrioridade.SelectedItem = _tarefa.Prioridade;
        }

        private async void OnSalvarClicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitulo.Text))
            {
                await DisplayAlert("Atenção", "O título não pode ficar vazio.", "OK");
                return;
            }

            // Atualiza o objeto Tarefa referenciado
            _tarefa.Titulo = txtTitulo.Text;
            _tarefa.Descricao = txtDescricao.Text;
            _tarefa.DataCriacao = dpData.Date;
            _tarefa.Prioridade = pckPrioridade.SelectedItem?.ToString() ?? "Baixa";

            // Fecha o modal (a página de detalhes atualizará os dados ao reaparecer)
            await Navigation.PopModalAsync();
        }

        private async void OnCancelarClicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}