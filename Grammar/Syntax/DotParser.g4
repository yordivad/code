parser grammar DotParser;

options {  
    language = CSharp;
	tokenVocab = DotLexer;
}

graph
   : STRICT? ( GRAPH | DIGRAPH ) id? LBRACE statement_list RBRACE
   ;

statement_list
   : ( statement SEMI? )*
   ;

statement
   : node_statement 
   | edge_statement 
   | attribute_statement 
   | id ASSIGN id 
   | subgraph
   ;

attribute_statement
   : ( GRAPH | NODE | EDGE ) attribute_list
   ;

attribute_list
   : ( LBRACK a_list? RBRACK )+
   ;

a_list
   : ( id ( ASSIGN id )? COMMA ? )+
   ;

edge_statement
   : ( node_id | subgraph ) edgeRHS attribute_list?
   ;

edgeRHS
   : ( edge_operation ( node_id | subgraph ) )+
   ;

edge_operation
   : ARROW 
   | OPTION
   ;

node_statement
   : node_id attribute_list?
   ;

node_id
   : id port?
   ;

port
   : COLON id ( COLON id )?
   ;

subgraph
   : ( SUBGRAPH id? )? LBRACE statement_list RBRACE
   ;

id
   : ID | STRING | HTML_STRING | NUMBER
   ;
