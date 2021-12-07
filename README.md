Desafio:
Um cliente precisa de um sistema que seja capaz de decompor um número em todos os seus divisores, enumerando também aqueles que forem primos.
Obs.: Não é permitido o uso de bibliotecas prontas, se houver, que façam a decomposição.
● Dado um número de entrada, o programa deve calcular todos os divisores que compõem o número.
● Dado um número de entrada, o programa deve calcular todos os divisores primos que compõem o número.

Como eu funciono:
    Back-end:
        Na pasta raiz, executar
            dotnet build
        Na pasta NumbDecomposer.API
            dotnet run (isso deverá subir a aplicação Web de forma local.)
            Em um navegador, acessar: https://localhost:xxxx/swagger
        
    Front-end:
        Tendo a API levantada, acessar a pasta NumbdecomposerAPP e executar
            ng serve
        Em um navegador, acessar: http://localhost:yyyy/