#language:pt-BR

Funcionalidade:1 TesteAPI


Esquema do Cenário: Api weather
	Quando faco a requisicao usando a <city>
	Entao o status code deve ser <status>
	

	Exemplos: 
	| city          | status |
	| Round Rock,TX | 200    |
	| Tampa,TX      | 204    |
	|               | 400    |
