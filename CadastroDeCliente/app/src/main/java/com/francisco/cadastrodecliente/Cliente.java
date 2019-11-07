package com.francisco.cadastrodecliente;

import java.io.Serializable;
import java.util.Random;

import androidx.annotation.NonNull;

public class Cliente implements Serializable {

    private long id;
    private String nome;
    private String endereco;
    private String telefone;


    public Cliente(String nome, String endereco, String telefone) {
        this.id = new Random().nextInt(9999);
        this.endereco = endereco;
        this.nome = nome;
        this.telefone = telefone;
    }

    public Cliente(long id, String nome, String endereco, String telefone) {
        this.id = id;
        this.endereco = endereco;
        this.nome = nome;
        this.telefone = telefone;
    }

    public Cliente() {
    }


    public long getId() {
        return id;
    }

    public void setId(long id) {
        this.id = id;
    }

    public String getNome() {
        return nome;
    }

    public void setNome(String nome) {
        this.nome = nome;
    }

    public String getEndereco() {
        return endereco;
    }

    public void setEndereco(String endereco) {
        this.endereco = endereco;
    }

    public String getTelefone() {
        return telefone;
    }

    public void setTelefone(String telefone) {
        this.telefone = telefone;
    }

    @NonNull
    @Override
    public String toString() {
        return getNome() + " - " + getTelefone()+ " - " + getEndereco() +" - ";
    }
}