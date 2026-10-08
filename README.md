# jogo_2D
jogo para nos treinar no github 67676767😜

25/08 - //Todos os dia deverão ter um relatorio da aula e que utilizando o git e na unity junto 
a documentação//. 
Hoje aprendemos sobre o Git, Github e o Git Desktop e versionamento de código usando termos como 
o "commit" que seria como uma foto do projeto mantendo ele salvo no 
Github e "push" e "pull" que envia o commit para o Github e para puxar o que os colegas enviaram 
e termos como o "branch" que são linhas paralelas de código utilizada para testar o jogo e 
"merge" que junta o trabalho de duas ou mais pessoas.

27/08 - //Game design//.
Hoje foi uma aula de game design é a area que cuida da elaboração do projeto, compreendendo seus
niveis, puzzles, artes, animação, mecanicas, roteiros e muito mais aprendemos sobre seus 5 tipos 
porem aprendemos so o primeiro que e game disign macânica que cuida de todo o processo criativo 
de como o jogo sera seus elementos jogaveis, tais como objetos, atributos, ações, regras e etc.

17/09/2026 - //inicio do game//.
Hoje foi uma aula para fazer a programação do jogo fizemos somente o movimento, por enquanto temos 
os movimentos basicos como para esquerda de direita e o pulo fizemos os commit delas e reaprendemos
a logar no git hub, git desktop,

22/09/2026 - //continuação do game//.
Hoje continuamos na programação basica do jogo fazendo a sua movimentação atualizando o script agora
para o player pular ele precisa estar no chão para ele conseguir pular usando o "OnCollisionEnter2D"
para detectar quando um objeto "rigidbody2D" esta encostando em outro ele pode ser usando quando um 
objeto precisa estar encostando em outro eu ja fiz o commit do novo script e ele ja esta no github.

29/09/2026 - //continuação da aula//.
Hoje fizemos a base para a primeira fase do jogo colocando as plataformas e obstaculos e o Vinicius vai 
passar a programação para a sala e eu já tinha feito anteriormente o script "Dano" E o Vinicius também nós 
ensinou que podemos fazer uma pasta chamada "Prefabs" que são os prefabricados onde podemos colocar um 
objeto ou obstaculo como um prefabricado e copiar e colar ele assim todos os objetos criados depois são 
ligados a ele então caso o DEV mude algo como sprit e script todos os outro também são alterados agora a 
fase esta quase pronta falta algumas coisas e os sprites para terminar a fase 1.

06/10/2026 - //finalização fase 1//.
Hoje o Vinicius esta corrigindo a prova que foi passada na ultima quinta enquanto ele faz isso nos 
terminamos a primeira fase do jogo eu terminei ela e foi fazer os script para ir de uma fase a outra 
enquanto ele termina depois ele passa uma atividade de adicionar uma mecanica extra no jogo eu fiz o script 
para o player mudar de fase e vou começar a fazer a fase 2 do jogo e minha tarefa já foi vistada pelo 
professor e não tenho tarefa que eu não fiz.   

08/10/2026 - //Tarefa de sala//.
Hoje a aula começou com o projeto de vida tomando as primeiras duas aula o que eu achei melhor do que sendo 
as ultimas e fizemos a tarefas e depois do recreio na terceira aula o pessoal de recuperação foi fazer a sua 
tarefa que era fazer o codigo do player inteiro sem internet como o movimento, pulo, verificar se esta 
encostando no chão para pular e o dano e enquanto isso as pessoas que não ficaram de recuperação tinha que 
fazer uma pesquisa sobre a biblioteca da untiy (using UnityEngine.SceneManagement) e depois poderia mexer no 
jogo e eu estou fazendo a segunda fase do meu jogo.
PESQUISA (using UnityEngine.SceneManagement)
{
    UnityEngine.SceneManagement
    UnityEngine.SceneManagement é um namespace da Unity responsável pelo gerenciamento de Scenes dentro de um projeto.
    Ele é utilizado quando um jogo precisa trabalhar com diferentes cenas, como:
    Menu principal
    Fases
    Tela de Game Over
    Tela de configurações
    Seleção de personagem
    Carregamento de diferentes ambientes
    Para utilizar esse namespace em um script C#, é necessário escrever:
    using UnityEngine.SceneManagement;
    O que é uma Scene?
    Uma Scene é uma parte organizada do projeto que contém elementos do jogo, como GameObjects, câmeras, luzes, ambientes e outros componentes.
    Um jogo pode possuir várias Scenes:
    Menu
     ↓
    Fase 1
     ↓
    Fase 2
     ↓
    Game Over
    O SceneManagement fornece as ferramentas necessárias para controlar essas Scenes.
    Principal classe: SceneManager
    Dentro de UnityEngine.SceneManagement existe a classe SceneManager.
    Ela é responsável por operações relacionadas às Scenes, como:
    SceneManager.LoadScene("Fase1");
    Esse comando solicita o carregamento da Scene chamada Fase1.
    Outras operações incluem:
    SceneManager.LoadSceneAsync("Fase1");
    para carregamento assíncrono;
    SceneManager.UnloadSceneAsync("Fase1");
    para descarregar uma Scene;
    SceneManager.GetActiveScene();
    para obter a Scene atualmente ativa.
    LoadSceneMode
    O namespace também possui o LoadSceneMode, que determina como uma Scene será carregada.
    Existem principalmente dois modos:
    LoadSceneMode.Single
    Carrega uma Scene substituindo a atual.
    LoadSceneMode.Additive
    Carrega uma Scene mantendo as outras Scenes carregadas.
    Por exemplo:
    SceneManager.LoadScene("Interface", LoadSceneMode.Additive);
    Nesse caso, a Scene Interface é adicionada às Scenes que já estão carregadas.
}
