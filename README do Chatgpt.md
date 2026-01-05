📄 Ficha de RPG — Ordem Paranormal

Projeto desenvolvido em Windows Forms (.NET) com o objetivo de representar uma ficha de personagem de Ordem Paranormal RPG, permitindo a consulta de atributos, perícias e inventário.

Atualmente, o projeto encontra-se em construção e está funcional apenas no modo leitura (read-only), com dados definidos diretamente no código.

🧩 Sobre o Projeto

Este projeto foi desenvolvido durante as férias como forma de estudo e prática com C# e Windows Forms.
A ideia inicial era criar uma ficha totalmente interativa e editável em tempo de execução, porém, devido a limitações de tempo e escopo, o projeto foi finalizado em sua versão atual como uma ficha apenas para consulta.

🛠️ Funcionalidades Atuais

Consulta de:

Atributos do personagem

Perícias

Inventário

Interface em Windows Forms

Organização dos dados em classes específicas

📌 Estado atual:
✔ Utilizável como ficha de consulta
❌ Não permite edição em tempo de execução
❌ Não salva alterações após fechar o programa

📂 Estrutura de Dados

Atualmente, os dados são definidos diretamente no código-fonte:

Personagem.cs
Contém os dados da ficha do personagem (atributos, inventário, perícias, etc).

DadosFixos.cs
Contém listas fixas de perícias, itens e outros dados utilizados na ficha.

Esta estrutura representa minha ficha pessoal atual, utilizada como base para testes.

❌ Funcionalidades Planejadas (não implementadas)

Ficha editável em tempo de execução

Salvamento de dados após o encerramento do programa

Sistema de persistência (TXT / JSON / banco de dados)

⚠️ A persistência não foi implementada pois as opções conhecidas envolviam armazenamento fora do executável (arquivos .txt ou .json no computador do usuário).
O desejo inicial era armazenar os dados internamente no executável, o que não é viável em aplicações Windows Forms compiladas.

🧪 Observações Técnicas

A pasta Packages contém diversos pacotes importados automaticamente pelo Visual Studio e não utilizados.

Estima-se que cerca de 3 MB do projeto sejam apenas dependências descartáveis.

A classe dadosMinimos.cs e algumas listas instanciadas em Personagem.cs não aparentam ter utilidade prática no estado atual do projeto.

Elas foram mantidas por serem parte de uma estrutura planejada para edição em tempo de execução.

Podem ser removidas ou reaproveitadas futuramente.

O projeto contém diversas funcionalidades desabilitadas ou invisíveis na interface, por não terem sido finalizadas de forma satisfatória dentro do tempo disponível.

🧠 Considerações Finais

Este projeto representa:

Um estudo prático de Windows Forms

Uma ficha funcional para consulta

Uma base sólida para futuras melhorias

Apesar de não estar completo, o código foi estruturado pensando em expansão futura, caso haja tempo para retomar o desenvolvimento.

📌 Status do Projeto

🚧 Em construção
📖 Modo leitura (read-only)
🕒 Desenvolvido durante as férias
