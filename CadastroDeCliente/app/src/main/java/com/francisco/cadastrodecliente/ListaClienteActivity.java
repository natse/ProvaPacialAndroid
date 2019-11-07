package com.francisco.cadastrodecliente;

import android.content.Intent;
import android.os.Bundle;
import android.text.Editable;
import android.text.TextWatcher;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.EditText;
import android.widget.ListView;
import android.widget.Toast;

import com.google.firebase.database.DataSnapshot;
import com.google.firebase.database.DatabaseError;
import com.google.firebase.database.DatabaseReference;
import com.google.firebase.database.FirebaseDatabase;
import com.google.firebase.database.Query;
import com.google.firebase.database.ValueEventListener;
import com.melnykov.fab.FloatingActionButton;

import java.util.ArrayList;
import java.util.List;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;

public class listarClienteActivity extends AppCompatActivity implements View.OnClickListener {

    private List<Cliente> clientes;
    private ArrayAdapter<Cliente> adapterCliente;
    private EditText editTxtpesquisar;
    private FloatingActionButton fab;
    private ListView lv;
    private DatabaseReference dbRef;
    private FirebaseDatabase firebaseDatabase;



    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_lista_cliente);

        initFirebaseReference();
        initViews();
        initModel();
        BuscarClientes("");
        eventoDePesquisa();
        ListViewOnClick();

    }

    //Nesse metodo, inicializo minha Reference do firebase.
    private void initFirebaseReference() {
        firebaseDatabase = FirebaseDatabase.getInstance();
        firebaseDatabase.setPersistenceEnabled(true); // Usando setPersistenceEnabled, permito que meu app funcione de forma offline.
        dbRef = firebaseDatabase.getReference();
    }

    private void initViews() {
        fab = findViewById(R.id.fab);
        lv = findViewById(R.id.lvPrdutos);
        editTxtpesquisar = findViewById(R.id.editTxtpesquisar);

        fab.setOnClickListener(this);
    }

    private void initModel() {
        clientes = new ArrayList<Cliente>();
    }

    @Override
    public void onClick(View v) {
        int id = v.getId();
        switch (id) {
            case R.id.fab:
                startActivity(new Intent(this, MainActivity.class));
                break;
        }
    }


    private void BuscarClientes(String nomeCliente){
        clientes.clear();
        Query query;
        if(nomeCliente.equals("")){
            query = dbRef.child("Cliente")
                    .orderByChild("nome");
        }else{
            query = dbRef.child("Cliente")
                    .orderByChild("nome")
                    .startAt(nomeCliente)
                    .endAt(nomeCliente + "\uf8ff");
        }

        query.addValueEventListener(new ValueEventListener() {
            @Override
            public void onDataChange(@NonNull DataSnapshot dataSnapshot) {
                clientes.clear();
                for (DataSnapshot obj : dataSnapshot.getChildren()){
                    Cliente cliente = obj.getValue(Cliente.class);
                    clientes.add(cliente);
                }
                adapterCliente =
                        new ArrayAdapter<Cliente>
                                (listarClienteActivity.this,
                                        android.R.layout.simple_list_item_1,
                                        clientes);

                lv.setAdapter(adapterCliente);
            }

            @Override
            public void onCancelled(@NonNull DatabaseError databaseError) {

            }
        });
    }

    private void eventoDePesquisa(){
        editTxtpesquisar.addTextChangedListener(new TextWatcher() {
            @Override
            public void beforeTextChanged(CharSequence s, int start, int count, int after) {

            }

            @Override
            public void onTextChanged(CharSequence s, int start, int before, int count) {

            }

            @Override
            public void afterTextChanged(Editable s) {
                String nomeCliente = editTxtpesquisar.getText().toString().trim();
                BuscarClientes(nomeCliente);
            }
        });
    }

    private void ListViewOnClick(){
        lv.setOnItemClickListener(new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick
                    (AdapterView<?> parent, View view, int position, long id) {
                GetCliente(position);
                Toast.makeText(listarClienteActivity.this
                        , "Cliente posição " + position
                        , Toast.LENGTH_LONG).show();
            }
        });
    }

    private void GetCliente(int posicao){
        Cliente cliente = clientes.get(posicao);
        Bundle bundle = new Bundle();
        bundle.putSerializable("cliente", cliente);
        Intent intent = new Intent(this,
                MainActivity.class);
        intent.putExtras(bundle);
        startActivity(intent);
    }
}
