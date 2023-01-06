Criar um controle de estoque dos alimentos e outros produtos da casa.

Também criar uma lista de compras que recebe os produtos e quantidade ou grama.

# Estoque
Deve conter:
- string NomeProduto,
- string Descrição,
- double PesoUnidade,
- int Quantidade,
- decimal Valor

## Todo

### BACK
- [x] Incluir, editar, atualizar e remover itens.
- [ ] Sugerir inclusão na lista de compras quando quantidade estiver menor que x.
- [x] Método GET para retornar todos os itens do estoque

### FRONT
- Tela inicial
- [ ] Exibir todos os itens na página inicial
- [ ] Conter barra de pesquisa
- [ ] A barra de pesquisa deve retornar os itens na tela inicial conforme o campo é preenchido.

- Tela para inclusao/Tela para alteração
- [ ] Exibir campos Nome, Descricao, Peso, Quantidade, Preco e Comprado.
- [ ] Conter botão para confirmar e outro para cancelar ação.

- Remoção de item
- [ ] Incluir botão para remoção de item
- [ ] Exibir um toast informando que o item foi removido.

# Lista de compras
Deve conter:
- string NomeProduto,
- string Descrição,
- double PesoUnidade,
- int Quantidade,
- decimal Valor,
- boolean Comprado

## Todo

### BACK
- [x] Incluir, editar, atualizar e remover itens.
- [x] Chamada para incluir os itens <u>comprados</u> no estoque. Em seguida, a lista deverá ser limpa.
- [x] Método GET para retornar todos os itens da lista

### FRONT
- Tela inicial
- [ ] Exibir todos os itens na página inicial
- [ ] Conter barra de pesquisa
- [ ] A barra de pesquisa deve retornar os itens na tela inicial conforme o campo é preenchido.
- [ ] Checkbox para marcar ou desmarcar a compra do item
- [ ] Botão para incluir os itens comprados no estoque
- [ ] Botão para limpar a lista

- Tela para inclusao/Tela para alteração
- [ ] Exibir campos Nome, Descricao, Peso, Quantidade, Preco e Comprado.
- [ ] Conter botão para confirmar e outro para cancelar ação.

- Remoção de item
- [ ] Incluir botão para remoção de item.
- [ ] Exibir um toast informando que o item foi removido.

