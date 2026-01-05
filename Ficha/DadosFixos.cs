using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class DadosFixos
    {

        public static List<Ritual> Rituais = new List<Ritual>
        {

        };

        public static List<Poder> Poderes = new List<Poder>
        {

        };

        public static List<ItemInventario> Itens = new List<ItemInventario>
        {
            new ItemInventario
            {
                Nome = "Lanterna Tatica",
                Descricao = "Ilumina lugares escuros. Além disso, você pode gastar uma ação de movimento para mirar a luz nos olhos de um ser em alcance curto. Ele fica ofuscado por 1 rodada, mas imune à lanterna pelo resto da cena."
            },
            new ItemInventario
            {
                Nome = "Pistola Sinalizadora",
                Descricao = "Esta pistola dispara um sinalizador luminoso. Pode ser usada como uma arma de disparo leve com alcance curto que causa 2d6 pontos de dano de fogo. A pistola vem com 2 cargas."
            }
        };

        public static List<Pericias> Pericia = new List<Pericias>
        {
            new Pericias
            {
                Nome = "INICIATIVA (AGI)",
                Atributo = "AGI",
                Descricao = "Esta perícia determina sua velocidade de reação. Quando uma cena de ação começa, cada personagem\r\nenvolvido faz um teste de Iniciativa. Eles então agem\r\nem ordem decrescente dos resultados",
                Bonus = "+5"
            },
            new Pericias
            {
                Nome = "INTUIÇÃO (PRE)",
                Atributo = "PRE",
                Descricao = "Esta perícia mede sua empatia e “sexto sentido”.\r\nPerceber Mentira. Você descobre se alguém está\r\nmentindo (veja a perícia Enganação).\r\nPressentimento (treinado, DT 20). Você analisa\r\numa pessoa, para ter uma ideia de sua índole ou\r\ncaráter, ou uma situação, para perceber qualquer\r\nfato estranho",
                Bonus = "+5"
            },
            new Pericias
            {
                Nome = "INVESTIGAÇÃO (INT)",
                Atributo = "INT",
                Descricao = "Você sabe como descobrir pistas e informações.\r\nInterrogar. Você descobre informações perguntando\r\nou indo para um lugar movimentado e mantendo\r\nos ouvidos atentos. Informações gerais (“Quem\r\né o dono desse bar?”) não exigem teste. Informações\r\nrestritas, que poucas pessoas conhecem (“Quem é\r\no delegado encarregado desse caso?”), têm DT 20.\r\nInformações confidenciais, ou que podem colocar\r\nem risco quem falar sobre elas, têm DT 30. Este uso\r\ngasta desde uma hora até um dia, a critério do mestre.\r\nProcurar. Você examina um local. A DT varia: 15\r\npara um item discreto ou no meio de uma bagunça,\r\nmas não necessariamente escondido; 20 para um item\r\nescondido (cofre atrás de um quadro, documento no\r\nfundo falso de uma gaveta); 30 para um item muito\r\nbem escondido (passagem secreta ativada por um\r\nbotão, documento escrito com tinta invisível). Este\r\nuso gasta desde uma ação completa (examinar uma\r\nescrivaninha) até um dia (pesquisar uma biblioteca).",
                Bonus = "+5"
            },
            new Pericias
            {
                Nome = "MEDICINA (INT)",
                Atributo = "INT",
                Descricao = "Você sabe tratar ferimentos, doenças e venenos.\r\nPrimeiros Socorros (DT 20). Um personagem\r\nadjacente que esteja morrendo e inconsciente perde\r\nessas condições e fica com 1 PV. A DT aumenta em\r\n+5 para cada vez que ele tiver sido estabilizado na\r\ncena. Este uso gasta uma ação padrão.\r\nCuidados Prolongados (Veterano, DT 20).\r\nDurante uma cena de interlúdio, você pode gastar\r\numa de suas ações para tratar até uma pessoa por\r\nponto de Intelecto. Se passar, elas recuperam o dobro\r\ndos PV pela ação dormir neste interlúdio.\r\nNecropsia (Treinado, DT 20). Você examina\r\num cadáver para determinar a causa e o momento\r\naproximado da morte. Causas raras ou extraordinárias,\r\ncomo um veneno exótico ou uma maldição,\r\npossuem DT +10. Este uso leva dez minutos.\r\nTratamento (Treinado). Você ajuda a vítima\r\nde uma doença ou veneno com efeito contínuo.\r\nGaste uma ação completa e faça um teste contra a\r\nDT da doença ou veneno. Se você passar, o paciente\r\nrecebe +5 em seu próximo teste de Fortitude contra\r\nesse efeito.\r\nEsta perícia exige um kit. Sem ele, você sofre –5 no\r\nteste. Você pode usar a perícia Medicina em si mesmo,\r\nmas sofre –O no teste.",
                Bonus = "+5"
            },
            new Pericias
            {
                Nome = "OCULTISMO (INT)",
                Atributo = "INT",
                Descricao = "Você estudou o paranormal.\r\nIdentificar Criatura. Você analisa uma criatura\r\nparanormal que possa ver. A DT do teste é igual à\r\nDT para resistir à Presença Perturbadora da criatura.\r\nSe você passar, descobre uma característica\r\nda criatura, como um poder ou vulnerabilidade.\r\nPara cada 5 pontos pelos quais o resultado do teste\r\nsuperar a DT, você descobre outra característica. Se\r\nfalhar por 5 ou mais, tira uma conclusão errada (por\r\nexemplo, acredita que uma criatura é vulnerável à\r\nMorte, quando na verdade é vulnerável a Energia).\r\nEste uso gasta uma ação completa.\r\nIdentificar Item Amaldiçoado (DT 20). Você\r\npode gastar uma ação de interlúdio para estudar um\r\nitem amaldiçoado e identificar seus poderes ou qual\r\nritual o objeto contém. Você pode sofrer –OO no teste\r\npara fazê-lo como uma ação completa.\r\nIdentificar Ritual (DT 10 +5 por círculo do\r\nritual). Quando alguém lança um ritual, você pode\r\ndescobrir qual é observando seus gestos, palavras e\r\ncomponentes. Este uso é uma reação.\r\nInformação. Você responde dúvidas relativas ao\r\nOutro Lado, objetos amaldiçoados, fenômenos paranormais,\r\nrunas, profecias, etc. Questões simples não\r\nexigem teste. Questões complexas exigem um teste\r\ncontra DT 20. Por fim, mistérios e enigmas exigem\r\num teste contra DT 30.",
                Bonus = "+5"
            },
            new Pericias
            {
                Nome = "PERCEPÇÃO (PRE)",
                Atributo = "PRE",
                Descricao = "Você nota coisas usando os sentidos.\r\nObservar. Você vê coisas discretas ou escondidas.\r\nA DT varia de 15, para coisas difíceis de serem\r\nvistas (um livro específico em uma estante) a 30,\r\npara coisas quase invisíveis (uma gota de sangue em\r\numa folha no meio de uma floresta à noite). Para\r\npessoas ou coisas escondidas, a DT é o resultado do\r\nteste de Furtividade ou Crime feito para esconder\r\na pessoa ou ocultar o item. Você também pode ler\r\nlábios (DT 20).\r\nOuvir. Você escuta barulhos sutis. Uma conversa\r\ncasual próxima tem DT 0 — ou seja, a menos que\r\nexista alguma penalidade, você passa automaticamente.\r\nOuvir pessoas sussurrando tem DT 15. Ouvir\r\ndo outro lado de uma porta aumenta a DT em +5.\r\nVocê pode fazer testes de Percepção para ouvir mesmo\r\nque esteja dormindo, mas sofre –OO no teste;\r\num sucesso faz você acordar. Perceber seres que\r\nnão possam ser vistos tem DT 20, ou +10 no teste\r\nde Furtividade do ser, o que for maior. Mesmo que\r\nvocê passe no teste, ainda sofre penalidades normais\r\npor lutar sem ver o inimigo.",
                Bonus = "+5"
            },
            new Pericias
            {
                Nome = "REFLEXOS (AGI)",
                Atributo = "AGI",
                Descricao = "Você usa esta perícia para testes de resistência contra\r\nefeitos que exigem reação rápida, como armadilhas e\r\nexplosões. A DT é determinada pelo efeito. Você também\r\nusa Reflexos para evitar fintas.",
                Bonus = "+5"
            },
            new Pericias
            {
                Nome = "SOBREVIVÊNCIA (INT)",
                Atributo = "INT",
                Descricao = "Você pode se guiar em regiões selvagens e evitar\r\nperigos da natureza.\r\nAcampamento (Treinado). Você pode conseguir\r\nabrigo e alimento nos ermos, caçando, pescando, colhendo\r\nfrutos, etc. A DT depende do tipo de terreno:\r\n15 para campo aberto, 20 para mata fechada e 25\r\npara regiões extremas, como desertos, pântanos ou\r\nmontanhas. Regiões especialmente áridas ou estéreis\r\ne clima ruim (neve, tempestade etc.) impõem uma\r\npenalidade de –5 (cumulativa). Se passar, você e seu\r\ngrupo podem usar as ações de interlúdio alimentar-se\r\ne dormir mesmo estando ao relento.\r\nIdentificar Animal (Treinado, DT 20). Com\r\numa ação completa, você pode identificar um animal\r\nexótico. Veja a perícia Ocultismo.\r\nOrientar-se. Um personagem viajando em regiões\r\nselvagens precisa fazer um teste de Sobrevivência por\r\ndia para avançar. A DT depende do tipo de terreno\r\n(veja acima). Se passar, você avança seu deslocamento\r\nnormal. Se falhar, avança metade. Se falhar por\r\n5 ou mais, se perde e não avança pelo dia inteiro.\r\nNum grupo, um personagem deve ser escolhido\r\ncomo guia. Personagens treinados em Sobrevivência\r\npodem fazer testes para ajudá-lo. Entretanto,\r\nse mais de um personagem quiser fazer o teste por\r\nsi só, todos deverão rolar os dados em segredo. Os\r\njogadores devem decidir qual guia seguir antes de\r\nverem o resultado!\r\nRastrear (Treinado). Você pode identificar e\r\nseguir rastros. A DT varia: 15 para rastrear um grupo\r\ngrande, ou um único ser em solo macio, como\r\nlama ou neve; 20 para um ser em solo comum (grama,\r\nterra); 25 para um ser em solo duro (estrada,\r\npiso de interiores). Visibilidade precária ou clima\r\nruim (noite, chuva, neblina) impõem –O no teste.\r\nVocê precisa fazer um teste por dia de perseguição.\r\nEnquanto rastreia, seu deslocamento é reduzido à\r\nmetade. Se falhar, pode tentar novamente gastando\r\nmais um dia. Porém, a cada dia desde a criação dos\r\nrastros, a DT aumenta em +1.",
                Bonus = "+5"
            },
            new Pericias
            {
                Nome = "TÁTICA (INT)",
                Atributo = "INT",
                Descricao = "Você recebeu educação militar.\r\nAnalisar Terreno (DT 20). Como uma ação de\r\nmovimento, você pode observar o campo de batalha.\r\nSe passar, descobre uma vantagem, como cobertura,\r\ncamuflagem ou terreno elevado, se houver.\r\nPlano de Ação (Veterano, DT 20). Como uma\r\nação padrão, você orienta um aliado em alcance\r\nmédio. Se passar, fornece +5 na Iniciativa dele. Se\r\nisso fizer com que um aliado que ainda não tenha\r\nagido nesta rodada fique com uma Iniciativa maior\r\ndo que a sua, ele age imediatamente após seu turno.\r\nNas próximas rodadas, ele age de acordo com\r\na nova ordem.",
                Bonus = "+5"
            },
            new Pericias
            {
                Nome = "TECNOLOGIA (INT)",
                Atributo = "INT",
                Descricao = "Você possui conhecimentos avançados de eletrônica\r\ne informática. Usos cotidianos, como mexer em um\r\ncomputador ou celular, não exigem treinamento\r\nnesta perícia ou testes. Esta perícia serve para usos\r\navançados, como reprogramar um sistema de vigilância\r\nou invadir um servidor seguro.\r\nFalsificação (Veterano). Como o uso de Enganação,\r\nmas apenas para documentos eletrônicos.\r\nHackear. Você invade um computador protegido.\r\nA DT é 15 para computadores pessoais, 20 para\r\nredes profissionais e 25 para grandes servidores\r\ncorporativos, governamentais ou militares. Este uso\r\ngasta 1d4+1 ações completas. Você pode sofrer uma\r\npenalidade de –O em seu teste para fazê-lo como\r\numa ação completa. Se falhar por 5 ou mais, pode\r\nser rastreado pelos administradores do sistema\r\nque tentou invadir.\r\nUma vez que invada o sistema, você pode fazer\r\no que veio fazer. Para procurar uma informação\r\nespecífica, veja o uso localizar arquivo, abaixo.\r\nOutras ações, como alterar ou deletar arquivos,\r\ncorromper ou desativar aplicativos ou bloquear\r\no acesso de outros usuários, podem exigir novos\r\ntestes de Tecnologia, à critério do mestre.\r\nLocalizar Arquivo. Você procura um arquivo\r\nespecífico em um computador ou rede que possa\r\nacessar (se você não tiver acesso ao sistema, precisará\r\nprimeiro invadi-lo; veja o uso hackear, acima).\r\nO tempo exigido e a DT do teste variam de acordo\r\ncom o tamanho do sistema no qual você está\r\npesquisando: uma ação completa e DT 15 para um\r\ncomputador pessoal, 1d4+1 ações completas e DT\r\n20 para uma rede pequena e 1d6+2 ações completas\r\ne DT 25 para uma rede corporativa ou governamental.\r\nEste uso se refere apenas a localizar arquivos\r\nem sistemas privados que você não conhece. Para\r\nprocurar informações públicas, na internet, use a\r\nperícia Investigação.\r\nOperar Dispositivo. Você opera um dispositivo\r\neletrônico complexo. Isso permite que você acesse\r\ncâmeras remotamente, destrave fechaduras eletrônicas,\r\native ou desative alarmes, etc. A DT é 15 para\r\naparelhos comuns, 20 para equipamento profissional\r\ne 25 para sistemas protegidos. Este uso gasta 1d4+1\r\nações completas e exige um kit. Você pode sofrer\r\numa penalidade de –O em seu teste para fazê-lo\r\ncomo uma ação completa. Sem o kit, você sofre –5\r\nnos testes de operar dispositivo.",
                Bonus = "+5"
            }
        };

    }

}


