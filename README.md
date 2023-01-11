Criar um controle de estoque dos alimentos e outros produtos da casa.

Também criar uma lista de compras que recebe os produtos e quantidade ou grama.

Mobile: https://github.com/matheusoc08/home-food-storage-android

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

