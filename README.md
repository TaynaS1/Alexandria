# 📚 Alexandria — Sua biblioteca pessoal

Sistema desktop em **C# Windows Forms** para registrar, organizar e avaliar os livros que você lê, com os dados salvos em **MySQL**.

## 📋 Descrição

O **Alexandria** é uma biblioteca pessoal. Na tela principal, a **Sua Estante**, cada livro aparece como um cartão com título, autor, gênero, status da leitura, nota em estrelas e resenha. Dá para cadastrar, editar, excluir e pesquisar livros, e tudo fica gravado no banco de dados.

## 🚀 Tecnologias Utilizadas

* **C#** com **.NET 10** (`net10.0-windows`) - Linguagem e plataforma
* **Windows Forms** - Interface gráfica
* **MySQL** - Banco de dados
* **MySql.Data 26.10.0** (NuGet) - Conexão com o MySQL via ADO.NET
* **Visual Studio** - IDE de desenvolvimento

## 🗄️ Estrutura do Banco de Dados

O banco se chama `alexandria` e usa duas tabelas.

### Tabela `livros`

| Coluna     | Tipo                                  | Descrição                                      |
|------------|---------------------------------------|------------------------------------------------|
| `id`       | INT, AUTO_INCREMENT, PRIMARY KEY      | Identificador do livro                         |
| `titulo`   | VARCHAR(150)                          | Título                                         |
| `autor`    | VARCHAR(150)                          | Autor                                          |
| `genero`   | VARCHAR(60)                           | Gênero                                         |
| `status`   | VARCHAR(30)                           | Quero ler, Estou lendo, Lido, Em pausa, Desisti |
| `nota`     | DOUBLE                                | Avaliação de 0 a 5                             |
| `resenha`  | TEXT                                  | Resenha do livro                               |

### Tabela `generos`

| Coluna | Tipo                              | Descrição                         |
|--------|-----------------------------------|-----------------------------------|
| `nome` | VARCHAR(60), PRIMARY KEY (ou UNIQUE) | Nome do gênero, sem repetição  |

### Script para criar o banco

```sql
CREATE DATABASE IF NOT EXISTS alexandria;
USE alexandria;

CREATE TABLE IF NOT EXISTS generos (
    nome VARCHAR(60) NOT NULL PRIMARY KEY
);

CREATE TABLE IF NOT EXISTS livros (
    id      INT AUTO_INCREMENT PRIMARY KEY,
    titulo  VARCHAR(150) NOT NULL,
    autor   VARCHAR(150) NOT NULL,
    genero  VARCHAR(60),
    status  VARCHAR(30),
    nota    DOUBLE,
    resenha TEXT
);

INSERT IGNORE INTO generos (nome) VALUES ('Romance'), ('Mistério'), ('Fantasia');
```

## ⚙️ Instalação e Configuração

### Pré-requisitos

* Visual Studio 2022 ou superior, com a carga de trabalho **Desenvolvimento para desktop com .NET**
* SDK do **.NET 10**
* **MySQL Server** em execução

### Passo a Passo

1. **Clone o repositório**

```
git clone https://github.com/TaynaS1/Alexandria.git
cd Alexandria
```

2. **Crie o banco de dados**
   * Abra o MySQL Workbench ou outro cliente MySQL
   * Execute o script SQL da seção acima

3. **Configure a string de conexão**
   * Abra o arquivo `Alexandria/bancoLivros.cs`
   * Ajuste a variável `conexao` com o servidor, a porta e as credenciais do seu MySQL

```csharp
private static string conexao =
    "Server=127.0.0.1;Port=3306;Database=alexandria;Uid=root;Pwd=SUA_SENHA;";
```

> A porta padrão do MySQL é `3306`. Use a porta em que o seu servidor estiver rodando.

4. **Restaure os pacotes NuGet**
   * O Visual Studio restaura automaticamente ao abrir a solução (`Alexandria.slnx`)
   * Se necessário, clique com o botão direito na solução e escolha "Restaurar Pacotes NuGet"

5. **Compile e execute**
   * Pressione `F5` ou clique em "Iniciar" no Visual Studio

## 🎯 Funcionalidades

* ✅ **Cadastro de livros** - Título, autor, gênero, status da leitura, avaliação e resenha
* 📖 **Estante em cartões** - Todos os livros aparecem como cartões, com nota em estrelas (★★★★☆)
* 🔍 **Busca em tempo real** - Filtra por título, autor, gênero ou status, ignorando maiúsculas e acentos
* 📝 **Edição** - Clique em um cartão (ou use o botão direito → *Editar*) para alterar os dados
* 🗑️ **Exclusão** - Pelo menu de contexto do cartão ou pelo botão **Excluir** na tela de edição, sempre com confirmação
* 🏷️ **Gêneros dinâmicos** - Escolha um gênero existente ou digite um novo; ele é salvo para os próximos cadastros
* ⭐ **Nota e resenha só para livros lidos** - Esses campos são liberados apenas quando o status é *Lido*, e a nota deve estar entre 0 e 5
* 💬 **Resenha em dica** - Passe o mouse sobre o cartão para ler a resenha completa

## 📁 Estrutura do Projeto

```
Alexandria/
├── Alexandria.slnx                  # Solução do Visual Studio
├── LICENSE.txt                      # Licença MIT
└── Alexandria/
    ├── Program.cs                   # Ponto de entrada da aplicação
    ├── Inicio.cs / Inicio.Designer.cs        # Tela principal (Sua Estante)
    ├── FormCadastroLivro.cs / .Designer.cs   # Formulário de cadastro e edição
    ├── Livros.cs                    # Modelo de dados do livro
    ├── bancoLivros.cs               # Acesso ao MySQL (inserir, listar, atualizar, excluir)
    ├── Properties/                  # Recursos do projeto (imagens e ícones)
    └── Alexandria.csproj            # Configuração do projeto e pacotes
```

## 🎨 Interface

Tema escuro com detalhes em roxo:

* **Início (Sua Estante)** - Cabeçalho com o logo, barra de navegação com o campo *Pesquisar livros*, área com os cartões dos livros e o botão **+Livro**
* **Cadastro** - Formulário com Título, Autor, Gênero, Status da Leitura, Avaliação e Resenha, e os botões **Salvar** e **Cancelar**

## 📝 Licença

Distribuído sob a licença MIT. Veja o arquivo [LICENSE.txt](LICENSE.txt).

## 👥 Autora

Desenvolvido por [TaynaS1](https://github.com/TaynaS1) como projeto do curso de Linguagem I.

---

> **Nota:** Este é um projeto educacional. Antes de usar em produção, mova a string de conexão para um arquivo de configuração e adicione validações e tratamento de erros adequados.
