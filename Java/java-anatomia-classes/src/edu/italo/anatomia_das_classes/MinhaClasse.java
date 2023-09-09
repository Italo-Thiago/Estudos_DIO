package edu.italo.anatomia_das_classes;
public class MinhaClasse {
  public static void main(String[] args) {
    
    String primeiroNome = "Italo";
    String segundoNome = "Thiado";

    String nomeCompleto = nomeCompleto(primeiroNome, segundoNome);
    System.out.println(nomeCompleto);
  }

  public static String nomeCompleto (String primeiroNome, String segundoNome ) {
    return "Resultado do método " + primeiroNome.concat(" ").concat(segundoNome);
  }

  } 