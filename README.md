# BlogAPI
API de Blog
Bem-vindo à documentação da API de um blog feita em .NET! Esta API foi desenvolvida para fornecer um conjunto de endpoints que permite gerenciar posts e usuários de um blog.

## Configuração
Antes de começar a usar a API, siga as instruções abaixo para configurar o ambiente de desenvolvimento:

Certifique-se de ter o .NET SDK instalado em sua máquina. Você pode fazer o download da versão mais recente em: https://dotnet.microsoft.com/download.

Clone o repositório do projeto do blog em seu ambiente local:

copie o código para o terminal para baixar o projeto
```
git clone https://github.com/stRafa/BlogAPI.git 
```
Acesse o diretório raiz do projeto:
```
cd blog-api
```
Abra o arquivo appsettings.json e verifique as configurações do banco de dados. Certifique-se de fornecer as informações corretas do servidor de banco de dados que você deseja utilizar.

Execute o seguinte comando para criar o banco de dados e executar as migrações iniciais:

copie o código para o terminal
```
dotnet ef database update
```
Agora você está pronto para executar a API. Utilize o seguinte comando para iniciar o servidor:
```
dotnet run
```
A API estará acessível em: https://localhost:7277.

## Endpoints
A API de blog fornece os seguintes endpoints:

### Autenticação
- POST /api/auth/register: Registra um novo usuário no blog.
- POST /api/auth/login: Realiza o login de um usuário e retorna um token de autenticação.

- GET /api/posts: Retorna uma lista de todos os posts.
- GET /api/posts/{id}: Retorna os detalhes de um post específico.
- POST /api/posts: Cria um novo post.
- PUT /api/posts/{id}: Atualiza um post existente.
- DELETE /api/posts/{id}: Exclui um post existente.

Para acessar os endpoints protegidos que requerem autenticação, você deve incluir um cabeçalho Authorization com o valor "Bearer {token}". O token de autenticação pode ser obtido através do endpoint de login.

#### Exemplo de Requisição
Aqui está um exemplo de como fazer uma requisição para criar um novo post utilizando o cURL:

### Considerações Finais
Esta documentação fornece uma visão geral dos principais endpoints disponíveis na API de blog feita em .NET. Certifique-se de ler e entender completamente a implementação dos endpoints antes de utilizá-los em produção.

Caso precise de mais informações sobre como utilizar a API, consulte o código fonte do projeto ou entre em contato com a equipe responsável pelo desenvolvimento.

Divirta-se usando a API de blog!
