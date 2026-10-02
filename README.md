# Trabalho Prático 02: App Lista de Tarefas

Trabalho prático 02 para a disciplina de **Programação para Dispositivos Móveis**, do curso de **Análise e Desenvolvimento de Sistemas (ADS)** no **IFSP – Campus Cubatão**[cite: 3].

Este projeto consiste em um aplicativo móvel construído com **.NET MAUI** e **C#**, implementando uma lista de tarefas dinâmica com navegação hierárquica e passagem de dados entre páginas e modais, sem a utilização de banco de dados.

## 📚 Sobre o projeto

O objetivo principal deste trabalho prático (TP 02) foi aplicar conceitos mais avançados de interface e navegação no .NET MAUI. O aplicativo permite o gerenciamento completo de tarefas na memória, explorando o uso de controles de lista, navegação entre páginas e janelas modais.

### Funcionalidades Implementadas

Atendendo aos requisitos propostos no enunciado, o aplicativo possui as seguintes funcionalidades:

- **Listagem de Tarefas:** Uma página inicial que utiliza o controle `ListView` para exibir o título e uma breve descrição de cada tarefa cadastrada.
- **Navegação Hierárquica (Detalhes):** Ao tocar em um item da lista, o aplicativo navega para uma página de detalhes que exibe informações completas da tarefa selecionada (Título, Descrição, Data de Criação e Prioridade).
- **Adição via Modal:** A partir da página inicial, um botão "Adicionar Nova Tarefa" abre uma página modal contendo um formulário para criação de novas atividades.
- **Edição via Modal:** Na tela de detalhes, o botão "Editar" abre um modal preenchido com os dados atuais da tarefa, permitindo atualizá-los.
- **Exclusão com Confirmação:** Na tela de detalhes, o usuário pode excluir a tarefa. Ao clicar no botão, um diálogo (`DisplayAlert`) pede a confirmação da ação antes de remover o item da lista e voltar à tela inicial.
- **Gerenciamento de Estado Dinâmico:** Utilização de `ObservableCollection<Tarefa>` e passagem de dados por construtor para garantir que a interface seja atualizada instantaneamente ao adicionar, editar ou remover itens.

## 🛠️ Tecnologias

- **C#**
- **.NET MAUI**
- **XAML**
- **.NET 9**

## 💻 Ambiente de desenvolvimento

O projeto foi desenvolvido e testado utilizando o seguinte ambiente:

- **IDE:** Visual Studio
- **Framework:** .NET 9 e .NET MAUI

## 👥 Autores (Dupla)

- **Lucas Santos** - [github/Lucas-Santos21](https://github.com/Lucas-Santos21)
- **Kaueh Farias** - [github/KauehF](https://github.com/KauehF)

---

**Curso:** Análise e Desenvolvimento de Sistemas – ADS 
**Instituição:** Instituto Federal de São Paulo – IFSP 
**Campus:** Cubatão – SP
**Disciplina:** Programação para Dispositivos Móveis