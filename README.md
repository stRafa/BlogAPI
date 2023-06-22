# BlogAPI
API de Blog
Bem-vindo à documentação da API de um blog feita em .NET! Esta API foi desenvolvida para fornecer um conjunto de endpoints que permite gerenciar posts, comentários e usuários de um blog.

##Configuração
Antes de começar a usar a API, siga as instruções abaixo para configurar o ambiente de desenvolvimento:

Certifique-se de ter o .NET SDK instalado em sua máquina. Você pode fazer o download da versão mais recente em: https://dotnet.microsoft.com/download.

Clone o repositório do projeto do blog em seu ambiente local:

bash
Copy code
´´´git clone https://github.com/stRafa/BlogAPI.git´´´
Acesse o diretório raiz do projeto:


cd blog-api
Abra o arquivo appsettings.json e verifique as configurações do banco de dados. Certifique-se de fornecer as informações corretas do servidor de banco de dados que você deseja utilizar.

Execute o seguinte comando para criar o banco de dados e executar as migrações iniciais:

sql
Copy code
dotnet ef database update
Agora você está pronto para executar a API. Utilize o seguinte comando para iniciar o servidor:

arduino
Copy code
dotnet run
A API estará acessível em: http://localhost:5000.

Endpoints
A API de blog fornece os seguintes endpoints:

Autenticação
POST /api/auth/register: Registra um novo usuário no blog.
POST /api/auth/login: Realiza o login de um usuário e retorna um token de autenticação.
Posts
GET /api/posts: Retorna uma lista de todos os posts.
GET /api/posts/{id}: Retorna os detalhes de um post específico.
POST /api/posts: Cria um novo post.
PUT /api/posts/{id}: Atualiza um post existente.
DELETE /api/posts/{id}: Exclui um post existente.
Comentários
GET /api/posts/{postId}/comments: Retorna todos os comentários de um post.
GET /api/comments/{id}: Retorna os detalhes de um comentário específico.
POST /api/posts/{postId}/comments: Adiciona um novo comentário a um post.
PUT /api/comments/{id}: Atualiza um comentário existente.
DELETE /api/comments/{id}: Exclui um comentário existente.
Autenticação
Para acessar os endpoints protegidos que requerem autenticação, você deve incluir um cabeçalho Authorization com o valor "Bearer {token}". O token de autenticação pode ser obtido através do endpoint de login.

Exemplo de Requisição
Aqui está um exemplo de como fazer uma requisição para criar um novo post utilizando o cURL:

bash
Copy code
curl -X POST -H "Content-Type: application/json" -H "Authorization: Bearer {token}" -d '{
  "title": "Meu primeiro post",
  "content": "Conteúdo do post..."
}' http://localhost:5000/api/posts
Considerações Finais
Esta documentação fornece uma visão geral dos principais endpoints disponíveis na API de blog feita em .NET. Certifique-se de ler e entender completamente a implementação dos endpoints antes de utilizá-los em produção.

Caso precise de mais informações sobre como utilizar a API, consulte o código fonte do projeto ou entre em contato com a equipe responsável pelo desenvolvimento.

Divirta-se usando a API de blog!
