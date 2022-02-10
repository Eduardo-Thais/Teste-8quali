# Teste-8quali
 
Para começar a utilizar o programa corretamente será necessario configurar o banco de dados:

Passo 1 - Criar banco de dados e pegar a String de conexão. Se estiver utilizando o Microsoft Visual Studio basta ir na aba "View"
e em "SLQ Server Object Explorer" então clique na flecha ao lado do SQL Server botão direito no "Databases" então "add New Database"
clicke com botão direito em cima do banco criado e propriedades e pegue a "Connection String".

Passo 2 - Substituir a String de conexão e utilizar o "Update-Database". Abra o arquivo "appsettings.json" e substitua a conection string apos "DataBase" 
depois na aba "Tools" vá em "NuGet Package Manager" e clicke em "Package Mannager Console" logo apos irá abrir o console e então
escreva "Update-Database" (sem as aspas) e aguarde finalizar e agora ja da de utilizar o programa 
normalmente.
