package de.bib.dozvjg.probeklausur;

import android.app.Activity;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;
import android.util.Log;
import android.widget.ArrayAdapter;
import android.widget.ListView;
import java.util.List;
import android.view.inputmethod.InputMethodManager;
import android.text.TextUtils;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;

import de.bib.dozvjg.probeklausur.framework.ViewModelFactory;

public class MainActivity extends Activity {

    public static final String LOG_TAG = MainActivity.class.getSimpleName();
    public MainActivityViewModel mViewModel;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        activateAddButton();
    }

    @Override
    protected void onResume() {
        super.onResume();

        mViewModel = (MainActivityViewModel)ViewModelFactory.INSTANCE.getViewModel(this,
                MainActivityViewModel.class);
        mViewModel.openDatabase();

        Log.d(LOG_TAG, "Folgende Einträge sind in der Datenbank vorhanden:");
        showAllListEntries();
    }

    @Override
    protected void onPause() {
        super.onPause();

        mViewModel.closeDatabase();
    }

    private void activateAddButton() {
        Button buttonAddProduct = (Button) findViewById(R.id.button_add_product);
        final EditText editTextQuantity = (EditText) findViewById(R.id.editText_quantity);
        final EditText editTextProduct = (EditText) findViewById(R.id.editText_product);
        final EditText editTextPrice = (EditText) findViewById(R.id.editText_price);

        buttonAddProduct.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

                String quantityString = editTextQuantity.getText().toString();
                String product = editTextProduct.getText().toString();
                String priceString = editTextPrice.getText().toString();

                if(TextUtils.isEmpty(quantityString)) {
                    editTextQuantity.setError(getString(R.string.editText_errorMessage));
                    return;
                }
                if(TextUtils.isEmpty(product)) {
                    editTextProduct.setError(getString(R.string.editText_errorMessage));
                    return;
                }
                if(TextUtils.isEmpty(priceString)) {
                    editTextPrice.setError(getString(R.string.editText_errorMessage));
                    return;
                }

                int quantity = Integer.parseInt(quantityString);
                float price = Float.parseFloat(priceString);
                editTextQuantity.setText("");
                editTextProduct.setText("");
                editTextPrice.setText("");

                mViewModel.createShoppingMemo(product, quantity, price);

                InputMethodManager inputMethodManager;
                inputMethodManager = (InputMethodManager) getSystemService(INPUT_METHOD_SERVICE);
                if(getCurrentFocus() != null) {
                    inputMethodManager.hideSoftInputFromWindow(getCurrentFocus().getWindowToken(), 0);
                }

                showAllListEntries();
            }
        });

    }

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        getMenuInflater().inflate(R.menu.menu_main, menu);
        return true;
    }

    @Override
    public boolean onOptionsItemSelected(MenuItem item) {
        int id = item.getItemId();
        if (id == R.id.action_settings) {
            return true;
        }

        return super.onOptionsItemSelected(item);
    }

    private void showAllListEntries () {
        List<ShoppingMemo> shoppingMemoList = mViewModel.getAllShoppingMemos();

        ArrayAdapter<ShoppingMemo> shoppingMemoArrayAdapter = new ArrayAdapter<> (
                this,
                android.R.layout.simple_list_item_multiple_choice,
                shoppingMemoList);

        ListView shoppingMemosListView = (ListView) findViewById(R.id.listiew_shopping_memos);
        shoppingMemosListView.setAdapter(shoppingMemoArrayAdapter);
    }
}
