parser grammar TinyParser;

options {  
	tokenVocab = TinyLexer;
}

unit 
	: method+ EOF
	;

method 
	: id LPAREN parameter RPAREN
	  block
	;

parameter 
	: id (COMMA id)*
	;


block
	: LBRACE statement* RBRACE
	;


statement
	: block
	| declaration
	| WHILE LPAREN expression RPAREN statement
	| RETURN expression SEMI
	;

declaration
	: expression SEMI
	| VAR expression SEMI
	;

expression
	: term
	| expression ASSIGN expression
	| expression bop=(ADD | SUB) expression
	| expression bop=(MUL | DIV | MOD) expression
	| expression bop=( LE | GE | LT | GT) expression
	;

term
   : id
   | integer
   ;

id
   : STRING
   ;

integer
   : INT
   ;


	
	

