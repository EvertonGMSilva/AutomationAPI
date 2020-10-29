#language:pt-BR


Funcionalidade:1 TestesMETA
Contexto: 

@mytag
Esquema do Cenario: 1_Teste META
	Dado que acesso a o link para Login
	E realizo o login
	E entro acesso o link para consulta de dados
	Quando digito a <City> e o <State>
	Então Valido o <Retorno> da API 

	Exemplos:
	| City       | State | Retorno     |
	| Round Rock | TX    | Success     |
	| Tampa      | TX    | Not Found   |
	| --         | --    | Bad Request |

Esquema do Cenario: 2_Teste META
	Dado que acesso a o link para Login
	E realizo o login
	E entro acesso o link para consulta de dados
	Quando digito a <City> e o <State>
	Então Valido o <Retorno> da api 

	Exemplos:
	| City  | State | Retorno     |
	| Tampa | TX    | Not Found   |
	| --    | --    | Bad Request |

