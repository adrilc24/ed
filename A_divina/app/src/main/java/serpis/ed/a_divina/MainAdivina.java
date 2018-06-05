package serpis.ed.a_divina;

import java.util.*;

import android.view.*;

import android.app.Activity;

import android.os.Bundle;

import android.view.View;

import android.widget.*;


public class MainActivity extends Activity

{

    @Override

    protected void onCreate(Bundle savedInstanceState)

    {

        super.onCreate(savedInstanceState);

        setContentView(R.layout.main);

    }

    Random appRandom = new Random();

    int hidRandom = appRandom.nextInt(81) + 10;

    public void takeGuess(View v)

    {

        EditText userGuess = (EditText) findViewById(R.id.myGuess);

        Double uGuess = Double.parseDouble(userGuess.getText().toString());

        if (uGuess hidRandom) {
        Toast toast = Toast.makeText(getApplicationContext(), “Too high!”, Toast.LENGTH_SHORT);

        toast.setGravity(Gravity.CENTER_VERTICAL|Gravity.CENTER, 0, 0);

        toast.show();
    } else {
        Toast toast = Toast.makeText(getApplicationContext(), “That’s right, you guessed it!”, Toast.LENGTH_SHORT);

        toast.setGravity(Gravity.CENTER_VERTICAL|Gravity.CENTER, 0, 0);

        toast.show();
    }

    }

}
