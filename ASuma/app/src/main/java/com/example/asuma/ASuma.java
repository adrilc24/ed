package com.example.asuma;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.EditText;

public class ASuma extends AppCompatActivity {
    public static final String MESSAGE_KEY = "MESSAGE_KEY";
    private static final String TAG = "MainActivity";

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_asuma);
        Log.i(TAG, "onCreate end");
    }

    public void hacerSuma(View view) {
        Log.i("MainActivity", "Suma de elementos");
        EditText editText = findViewById(R.id.editText);
        Intent intent = new Intent(this, DisplayMessageActivity.class);
        intent.putExtra(MESSAGE_KEY, editText.getText().toString());
        startActivity(intent);
    }
}
