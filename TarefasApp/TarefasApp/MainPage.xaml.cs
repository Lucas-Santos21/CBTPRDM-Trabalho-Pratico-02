//Nome e prontuário da dupla:
//Lucas da Silva Santos CB3030598
//Kaueh Farias Ferreira dos Santos CB3031438

using System.Collections.ObjectModel;

namespace TarefasApp
{
    public partial class MainPage : ContentPage
    {
        // ObservableCollection avisa o ListView quando algo é adicionado ou removido
        public ObservableCollection<Tarefa> Tarefas { get; set; }

        public MainPage()
        {
            InitializeComponent();

            Tarefas = new ObservableCollection<Tarefa>
            {
                new Tarefa { Titulo = "Page 1", Descricao = "Criação da página inicial", DataCriacao = DateTime.Now, Prioridade = "Alta" },
                new Tarefa { Titulo = "Page 2", Descricao = "Criação da página de detalhes", DataCriacao = DateTime.Now, Prioridade = "Média" }
            };

            listViewTarefas.ItemsSource = Tarefas;
        }

        // Navegação para os Detalhes (Hierárquica)
        private async void OnTarefaTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item is Tarefa tarefaSelecionada)
            {
                // Passando a tarefa selecionada e a lista completa (para poder excluir depois)
                await Navigation.PushAsync(new PaginaDetalhes(tarefaSelecionada, Tarefas));

                // Tira a seleção visual do item na lista
                ((ListView)sender).SelectedItem = null;
            }
        }

        // Navegação para o Modal de Adição
        private async void OnAdicionarClicked(object sender, EventArgs e)
        {
            // Passamos a lista para o modal poder adicionar a nova tarefa nela
            await Navigation.PushModalAsync(new ModalAdicionar(Tarefas));
        }
    }
}