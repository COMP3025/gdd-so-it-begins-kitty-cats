# GDD (Game Design Document)

Um "Game Design Document" (GDD) é um documento crucial para o desenvolvimento de jogos, pois descreve em detalhes a visão, a mecânica e todos os elementos importantes do jogo. Embora o conteúdo exato de um GDD possa variar dependendo do projeto, alguns tópicos importantes que geralmente são incluídos são:

1. **Visão Geral do Jogo:**
   猫 の 冒険 (Aventura dos Gatinhos) será um jogo sobre o cotidiano de gatinho de rua, seguindo o estilo plataforma, a ideia é que o personagem terá que passar por vários desafios e obstáculos durante três fases.

   Durante todo esse percurso, existirão alguns itens colecíonáveis. Caso o jogador consiga passar por todas as fases, terá como último desafio derrotar um boss final e, caso obtenha sucesso, terá acesso ao final feliz onde o gatinho encontra uma família para adotá-lo.
2. **Mecânica de Jogo:**
   - Será um jogo de Plataforma
   - Regras e sistemas que governam o funcionamento do jogo.
3. **História e Narrativa:**
   - O jogo tem como premissa inicial a vida de um gatinho de rua, que terá que passar pelos obstáculos do dia a dia para consegui chegar no final do dia seguro em sua casa, uma caixa de papelão.
   - No decorrer da aventura do gatinho, ele terá que enfrentar obstáculos cotigianos da vida na rua, como cones, latas de lixo, barraca de feira, placas, além de inimos, podendo ser outros gatos ou cachorros.
   - No final de sua aventura, o gatinho terá que enfrentar o cachorro mais assustador da rua, e depois da sua ardua aventura, o gatinho será recopensado com uma grata surpresa, sendo adotado por uma família carinhosa.

4. **Personagens e Inimigos:**
   - Gatinho(sem nome ?)
         - movimentacao direita, esquerda , pulo e dash(?)
         - ataca os inimigos atirando bolas de pelo com uma pistola(-0.5HP) nas costas de perto consegue usar arranhao(-1HP) (desbloqueia inicialmente somente o arranhao)
   - Objetos no chão que dão dano
         - desvia pulando.
         - garrafas quebradas no chão e plantas espinhosas  
   - Ratos gigantes
         - 1HP
         - andam em linha reta pelo mapa
         - dao dano se encostar (-1HP)
   - Mini dogos
         - 2HP
         - ficam parados
         - atiram para os dois lados (-1HP)
         - dao dano se encostar (-1HP)
   - Gaivotas malditas
         - 1HP
         - voam em linha reta pelo mapa
         - dano ao encostar (-1HP)
   - EL BOSS DO CANIL
         - mini mafia de dogs
         - todos com uma arma nas costas e um oculos de sol
         - 20HP
         - 1º fase:
            - realiza uma sequencia de tiros em linha reta, que pode ser desviado pulando
            - faz uma mini explosão que causa dano em sua volta
         - 2º fase:
            - mesmos golpes da fase um
            - misseis que caem do céu
            - se move para o outro lado da tela a cada skill utilizada

5. **Níveis e Ambientes:**
   - Níveis com progressão linear, permitindo que o jogador avance direto para o próximo nível assim que concluída a fase.
   - Ambientação urbana contendo diversos obstáculos como cones, latas de lixo, barraca de feira e placas.
   - Coletáveis: novelo de lã, rato de brinquedo, patê, cobertinha provendo score para o jogador e moedas(peixes).

6. **Arte e Estilo Visual:**
   - Todas as artes do jogo (ambientação, UI, personagens e etc) seguirão o estilo gráfico de pixelarts.

7. **Áudio e Trilha Sonora:**
   - Serão usadas músicas no estilo Lo-Fi, mixadas em 8-bits.

8. **Interface do Usuário (UI):**
   - Menu inicial com a opção de startar o game;
   - Menu para escolher a pelagem do gatinho;

9. **Progressão e Recompensas:**
   - Durante o jogo o jogador deverá passar por 3 fases e 1 boss. Dentro de cada fase terá um desafio diferente e o jogador deverá passar por todas elas para chegar ao grande final.
   - Cada fase terá uma mini recompensa, sendo elas itens que gatinhos gostam, como por exemplo: novelo de lã, rato de brinquedo, patê, cobertinha. Ao finalizar cada fase, se o jogador tiver pego as recompensas, o gatinho irá ficar com todos os itens dentro de sua caixinha.
   - Ao chegar ao final, depois do boss, a recompensa do gatinho é ser adotado por uma familia que irá Amá-lo e todas as outras recompensas obtidas durante o jogo irão junto com ele.

10. **Controle de Jogo e Mapeamento de Teclas:**
    - Seta para direita [&rarr;]: anda para frente.
    - Seta para esquerda [&larr;]: anda para trás.
    - Seta para cima [&uarr;]: pula.
    - Seta para cima segurada [&uArr;]: pulo longo.
    - Seta para baixo [&darr;]: se abaixa.
    - Z: atirar.
    - X: arranha.
    - C: dash.

11. **Fluxo do Jogo:**
    - O jogo será um plataforma linear, com o personagem principal seguindo sempre para direita até o final da fase.
    - O mesmo cenário usado para finalizar uma fase será usado para iniciar a próxima, com apenas variações temporais, como dia, noite, tarde e chuva.

12. **Considerações Técnicas:**
    - Sistema Operativo: Windows XP, Vista, 7, 8, or 10.
    - Memória: 2 GB de RAM.
    - Placa gráfica: 128MB.
    - Espaço no disco: Requer 200 MB de espaço livre.

13. **Equipe de Desenvolvimento:**
    - Ana
    - Dani
    - Eduardo
    - Fernando
    - Maria

14. **Cronograma de Desenvolvimento:**
    - Criação de esboços;
         - telas;
         - personagens;
         - itens;
    - Criação das artes e animações para o jogo;
    - Codificação;
