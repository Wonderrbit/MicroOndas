Avaliaçao e Orientaçao a Objeto
Objetivo
Programar em Web um MICRO-ONDAS DIGITAL.
Requisitos
Os requisitos foram separados em níveis de dificuldade. Primeiro atenda aos requisitos do nível 1, para então
atender aos requisitos do nível 2, e assim por diante. No mínimo os requisitos do nível 3 devem ser entregues ao
final da avaliação. Ao entregar, informe qual nível o programa atende. A consulta da Web é permitida durante a
avaliação, porém tudo que for implementado, tenha sido copiado da internet ou não, será avaliado.
Os seguintes requisitos são OBRIGATÓRIOS em todos os níveis:
A. Utilize conceitos de orientação a objetos;
B. .Net Framework 4.0 ou superior;
C. Não se preocupar com o visual do formulário, mas sim com a implementação do micro-ondas
D. Separar as camadas de interface de usuário e de negócio;
E. O programa desenvolvido deve funcionar conforme os requisitos de cada nível;
Os seguintes requisitos são DESEJÁVEIS E DIFERENCIAIS em todos os níveis:
F. Observar os princípios SOLID.
G. Design patterns.
H. Boas práticas e qualidade de código visando facilidade de leitura e compreensão.
I. Implementar as classes de maneira a prevenir o uso incorreto, protegendo devidamente o acesso aos dados
e métodos.
J. Documentar o código quando necessário.
K. Implementar testes unitários para a camada de negócio.
Nível 1
1. Crie uma interface em que seja possível informar um tempo e a potência.
a. A distribuição dos campos fica a critério do desenvolvedor.
b. A tela deverá ter a opção de informar os números por um teclado digital e ou input por teclado.
c. A linguagem que será utilizada para o desenvolvimento da interface fica a critério do desenvolvedor.
sugere-se que seja algo facilmente integrável ao backend em C# podendo ser desktop ou web.
2. Criar método para iniciar o aquecimento, sendo parametrizável o tempo e a potência.
a. O tempo máximo é 2 minutos e o mínimo é 1 segundo.
b. A potência varia de 1 a 10 assumindo 10 como padrão, então caso o usuário não informe a potência o
valor 10 será assumido.
c. caso o usuário informe um tempo maior que 60 segundos e menor que 100 segundos o programa deverá
converter o tempo em minutos, exemplo: usuário informa 90 segundos, ao acionar o aquecimento o valor exibido
deverá ser 1:30.
3. Validações de operação:
a. Caso o tempo seja informado fora dos limites definidos (menor que 1 ou maior que 2 minutos) deverá
exibir uma mensagem solicitando um tempo valido.
b. Caso a potência for informada com um valor menor que 0 ou maior que 10 o sistema deverá exibir
mensagem.
c. em caso de potência não informada, será inserido em tela o valor 10 como padrão.
4. Deverá possibilitar o "início rápido" que se define por apertar o botão de aquecimento sem informar tempo ou
potência, neste caso o programa iniciará o aquecimento com a potência 10 e o tempo será 30 segundos.
5. Acréscimo de tempo durante o aquecimento: Caso o usuário pressione o botão de iniciar aquecimento com um
aquecimento já em execução o programa deverá acrescentar 30 segundos no tempo que estiver faltando.
6. String informativa do processo de aquecimento: Durante o processo de aquecimento uma string de label deverá
ser exibida e atualizada em tela, para dar a noção de processamento.
a. A string será no seguinte formato: o caractere usado será o "." e a quantidade de caracteres por segundo
vai variar de acordo com a potência definida. Exemplo: tempo de 10 segundos com a potência 1 o resultado final
será ". . . . . . . . . .". tempo 5 com potência 3: "... ... ... ... ...". Assim por diante.
b. Ao final do processo no final dessa string deverá ser concatenado a frase "Aquecimento concluído".
7. Pausa e cancelamento de aquecimento:
a. O programa deverá ter um botão único para pausa e cancelamento. Se o aquecimento estiver em
andamento e este botão for acionado o programa pausará o aquecimento. Caso o botão de iniciar seja acionado
nesta situação o aquecimento prosseguirá do ponto onde parou.
b. Caso o botão de pausa / cancelamento seja acionado com o aquecimento pausado o aquecimento será
cancelado, limpando todas as informações em tela e interrompendo o aquecimento.
c. Caso o botão de pausa / cancelamento seja acionado antes do aquecimento ser iniciado, as informações
de tempo e potência serão limpadas.
Nível 2
1. Programas de aquecimento pré-definidos
a. O programa deverá disponibilizar 5 programas de aquecimento pré-definidos programas de aquecimento
deverão ter as seguintes informações: Nome do programa, alimento, tempo, potência, string de aquecimento e
instruções complementares.
b. Cada programa deverá utilizar uma string de aquecimento diferenciada, não podendo repetir entre outros
programas e não poderá ser o caractere ".".
c. Os programas pré-definidos não poderão ser alterados ou excluídos.
d. Ao selecionar um programa os dados referentes a potência e tempo deverão ser preenchidos de forma
automática não permitindo a troca das informações.
e. Para programas pré-definidos não será permitido o acrescimento de tempo.
f. As ações de pausa e cancelamento serão permitidas.
Programas de aquecimento pré-definidos:
1. Nome: Pipoca
Alimento: Pipoca (de micro-ondas)
tempo: 3 minutos
potência: 7
Instruções: Observar o barulho de estouros do milho, caso houver um intervalo de mais de 10 segundos entre um
estouro e outro, interrompa o aquecimento.
2. Nome: Leite
Alimento: Leite
tempo: 5 minutos
potência: 5
Instruções: Cuidado com aquecimento de líquidos, o choque térmico aliado ao movimento do recipiente pode
causar fervura imediata causando risco de queimaduras.
3. Carnes de boi
Alimento: Carne em pedaço ou fatias
tempo: 14 minutos
potência 4
Instruções: Interrompa o processo na metade e vire o conteúdo com a parte de baixo para cima para o
descongelamento uniforme.
4. Frango
Alimento: Frango (qualquer corte)
tempo: 8 minutos
potência: 7
Instruções: Interrompa o processo na metade e vire o conteúdo com a parte de baixo para cima para o
descongelamento uniforme.
5. Feijão
Alimento: Feijão congelado
tempo: 8 minutos
potência 9
Instruções: Deixe o recipiente destampado e em casos de plástico, cuidado ao retirar o recipiente pois o mesmo
pode perder resistência em altas temperaturas.
Nível 3
1. Cadastro de programas de aquecimento customizados:
a. O programa deverá permitir o cadastro de programas de aquecimento customizados, as informações de
nome do programa, alimento, potência, caractere de aquecimento e tempo deverão obrigatoriamente ser
preenchidos.
b. As instruções de uso têm o preenchimento opcional.
c. O caractere de aquecimento deverá ser validado e não poderá se repetir com qualquer programa de
aquecimento ou ao caractere padrão "."
d. Os programas customizados deverão ser exibidos juntamente aos programas pré-definidos, porém a fonte
dele deverá ser em itálico para diferenciar.
e. A persistência dos programas customizados poderão ser feitos em arquivo JSON ou em banco de dados
SQL Server.
Nível 4
1. Exportação de regras para WEB API:
a. Todos os métodos de negócio, tanto de aquecimento quanto cadastro, utilização e manutenção de
programas de aquecimento deverão possuir endpoints em uma web api.
b. A API deverá possuir autenticação utilizando o padrão BEARER TOKEN.
c. O programa deverá exibir um status se a autenticação com a API ocorreu com sucesso, e caso não
nenhuma das funções poderão ser executadas.
d. A configuração das credenciais de autenticação deverá ser efetuada no programa em uma sessão
específica para isso. O campo de senha deverá ser mascarado.
e. A senha do usuário deverá ser criptografada utilizando o padrão SHA1 (256 bits) para persistência.
f. Em caso de utilização de banco de dados para persistência a connection string deverá ser criptografada. (A
connection string descriptografada deverá ser enviada na documentação)
2. Tratamento de exceptions:
a. Deverá ser criado um mecanismo de tratamento de exceptions e gerenciamento para uma resposta em
formato padrão.
b. Deverá ser criado uma exception específica para tratamento de regras de negócio do sistema.
c. Todos as exceptions não tratadas deverão ser logadas em um arquivo de texto ou banco de dados
exibindo a Exception, Inner Exception, stacktrace e informações relevantes.
