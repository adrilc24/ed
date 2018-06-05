package com.example.adrcre.emparejar_numeros;

import android.os.Handler;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.GridLayout;

import java.util.Random;

public class juego extends AppCompatActivity implements View.OnClickListener{

    private int numberOfElements;
    private botMemoria[] buttons;
    private int[] buttonGraphicLocations;
    private int [] buttonGraphics;

    private botMemoria selectedBot1;
    private botMemoria SelectedBot2;

    private  boolean isBusy = false;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_juego);

        GridLayout gridLayout = (GridLayout)findViewById(R.id.grid_Layout_4x4);

        int numColumns = gridLayout.getColumnCount();
        int numRows = gridLayout.getRowCount();

        numberOfElements = numColumns * numRows;
        buttons = new botMemoria[numberOfElements];

        buttonGraphics = new int [numberOfElements / 2];

        buttonGraphics[0] = R.drawable.bot1;
        buttonGraphics[1] = R.drawable.bot2;
        buttonGraphics[2] = R.drawable.bot3;
        buttonGraphics[3] = R.drawable.bot4;
        buttonGraphics[4] = R.drawable.bot5;
        buttonGraphics[5] = R.drawable.bot6;
        buttonGraphics[6] = R.drawable.bot7;
        buttonGraphics[7] = R.drawable.bot8;

        buttonGraphicLocations = new int [numberOfElements];

        shuffleButtonGraphics();

        for(int r = 0; r < numRows; r++){
            for(int c = 0; c < numColumns; c++){
                botMemoria tempButton = new botMemoria(this, r, c, buttonGraphics[buttonGraphicLocations[r*numColumns+c]]);
                tempButton.setId(View.generateViewId());
                tempButton.setOnClickListener(this);
                buttons[r * numColumns + c] = tempButton;
                gridLayout.addView(tempButton);
            }
        }
    }

    protected void shuffleButtonGraphics(){
        Random rand = new Random();

        for (int i = 0; i < numberOfElements; i++){
            buttonGraphicLocations[i] = i % (numberOfElements / 2);
        }
        for(int i = 0; i < numberOfElements; i++){
            int temp = buttonGraphicLocations[i];
            int swapLocation = rand.nextInt(16);
            buttonGraphicLocations[i] = buttonGraphicLocations[swapLocation];
            buttonGraphicLocations[swapLocation] = temp;
        }
    }

    @Override
    public void onClick(View view) {

        if(isBusy)
            return;
        botMemoria button = (botMemoria) view;

        if(button.isMatched)
            return;

        if (selectedBot1 == null){
            selectedBot1 = button;
            selectedBot1.flip();
            return;
        }
        if (selectedBot1.getId() == button.getId())
            return;
        if (selectedBot1.getFrontDrawableId() == button.getFrontDrawableId()){
            button.flip();
            button.setMatched(true);
            selectedBot1.setMatched(true);

            selectedBot1.setEnabled(false);
            button.setEnabled(false);

            selectedBot1 = null;
            return;
        }

        else {
            SelectedBot2 = button;
            SelectedBot2.flip();
            isBusy = true;

            final Handler handler = new Handler();

            handler.postDelayed(new Runnable() {
                @Override
                public void run() {
                    SelectedBot2.flip();
                    selectedBot1.flip();
                    selectedBot1 = null;
                    SelectedBot2 = null;
                    isBusy = false;

                }
            }, 500);
        }
    }
}