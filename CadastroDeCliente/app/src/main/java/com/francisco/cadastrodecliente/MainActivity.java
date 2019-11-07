package com.francisco.cadastrodecliente;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

import com.google.firebase.database.DatabaseReference;
import com.google.firebase.database.FirebaseDatabase;

import androidx.appcompat.app.AppCompatActivity;

public class MainActivity extends AppCompatActivity implements View.OnClickListener {

    private FirebaseDatabase firebaseDatabase;
    private DatabaseReference db;
    private Cliente cliente;
    private EditText editTxtNome, editTxtTelefone, editTxtEndereco;
    private Button btnSalvar;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        firebaseDatabase = FirebaseDatabase.getInstance();
        db = firebaseDatabase.getReference("Cliente");

        initViews();
    }

    protected void initViews() {
        editTxtNome = findViewById(R.id.editTxtNome);
        editTxtTelefone = findViewById(R.id.editTxtTelefone);
        editTxtEndereco = findViewById(R.id.editTxtEndereco);
        btnSalvar = findViewById(R.id.btnSalvar);
        btnSalvar.setOnClickListener(this);
    }

    @Override
    public void onClick(View v) {

        initModel();
        SalvarCliente();

        finish();
    }

    private void SalvarCliente(){
        db.child(String.valueOf(cliente.getId())).setValue(cliente);
        showToast("Cliente Salvo com sucesso");
    }

    protected void initModel() {
        cliente = new Cliente(editTxtNome.getText().toString().trim(), editTxtEndereco.getText().toString().trim(), editTxtTelefone.getText().toString().trim());

    }

    private void showToast( String message ){
        Toast.makeText(this, message, Toast.LENGTH_LONG).show();
    }
}
