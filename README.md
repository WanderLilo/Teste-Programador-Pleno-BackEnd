# Desafio Desenvolvedor Back End Pleno 2021 AGROCP


Todas as tarefas tem que ser feitas em ASP NET CORE 3 ou NET CORE 5 com Entity Framework

- Todas as tarefas, serão avaliadas, faça o que puder. As tarefas terão que ser entregues em dois dias desde do envio por email.

Desenvolver as tarefas, fazendo um fork neste repositorio, em pastas separadas, seguindo o número da tarefa, como o nome da pasta Exemplo: "tarefa-1"

Tarefas:

1º Tarefa 

Criar um banco de dados contendo informações dos estados e cidades do Brasil. Deixe em anexo o sql do banco. Pode usar tanto SQL como NOSQL e utilizar Entity Framework nas consultas.
Neste mesmo banco crie uma tabela de pessoa com os campos nome, cpf, estado e cidade.
Tambem criar uma tabela de log, colocando os campos:  função usada, acao, hora e data


2º Tarefa

Desenvolva uma api com os seguintes controllers,

Coleta das cidades de um estado.
Coleta das cidades de um estado usando paginação nos dados.
Criar uma função para inserir novas cidades.
Criar uma função para atualizar novas cidades.
Criar uma função para verificar se a cidade existe.
Usar Data Anotations para validar os campos.
Desenvolver Testes Unitarios das tarefas acima.

3º Tarefa

Crie uma api que colete dados de uma pessoa como nome, cpf, estado e cidade e faça a inserção na tabela do banco pessoa.
Usar Data Anotations para validar os campos.
Essa api tem que consumir a outra api da tarefa 2 para validar se a cidade que usuario colocou tem no banco de dados.

4º Tarefa 

Desenvolver uma api com WebSocket usando signalr, conectando os dois servidores e coletar informações em tempo real de uma ação feita, e inserir na tabela de logs.


Todas as tarefas da api é necessario a documentação em Swagger.

Enviar o link do fork no email williambatista@cpagricola.com.br
