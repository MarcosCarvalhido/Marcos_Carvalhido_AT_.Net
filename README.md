![Logo do Instituto Infnet](https://curso.infnet.com.br/c/wp-content/uploads/sites/59/2022/12/Infnet-Logo.png)

# ASSESSMENT

## **Desenvolvimento Web com .NET e Bases de Dados [24E1_4]**

## **Bloco: Desenvolvimento Back-end [23E4 - 24E1]**

### [GRPADS01C2-N1-P2] - Classe 2 - Noite

Por Marcos Carvalhido Rodrigues

*marcos.carvalhido@al.infnet.edu.br*

Professor: Luiz Paulo Bomeny Maia

---

Link para o AT no Moodle: [https://lms.infnet.edu.br/moodle/mod/assign/view.php?id=37685](https://lms.infnet.edu.br/moodle/mod/assign/view.php?id=376858)


### Questões:

1. Crie uma aplicação Web no Visual Studio, utilizando o template correspondente com o nome InfnetMVC e implementando o tipo de autenticação de Contas Individuais (Individual Accounts).
2. Crie uma pasta Models e, dentro da pasta, crie uma classe *Aluno* com seguintes atributos:
    1. Id;
    2. Nome;
    3. Endereco;
    4. Telefone;
    5. Email;
    6. Data de nascimento.
3. Crie uma pasta *Alunos* dentro da pasta *Pages* e, a partir do Scaffold, adicionar as páginas Razor utilizando o Entity Framework.
4. Selecione a classe *Aluno* como modelo e crie uma classe DbContext com o nome *InfnetDbContext*.
5. Execute o Add-Migration e Update-Database.
6. Altere a aplicação para que a página Index da pasta *Alunos* seja a página inicial.
7. Teste a aplicação realizando um CRUD de um aluno.
8. Altere a classe *Aluno* para realizar as seguintes validações e/ou formatações: 
    1. o nome deve ter no mínimo quatro caracteres e no máximo 50; 
    2. a data deve ser apresentada como “**Data de Nascimento**” no formulário 
    3. e  apresentar apenas a opção de data, sem a hora.
9. Inclua na página de Index uma busca por nome de aluno.
10. Implemente um controle de acesso que permita que apenas o coordenador possa **incluir, alterar e excluir** alunos, enquanto o aluno possa apenas consultar os dados.
