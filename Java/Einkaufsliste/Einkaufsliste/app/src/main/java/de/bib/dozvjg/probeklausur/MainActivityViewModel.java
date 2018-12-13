package de.bib.dozvjg.probeklausur;

import android.app.Activity;
import android.util.Log;

import java.util.List;

import de.bib.dozvjg.probeklausur.framework.ViewModel;

public class MainActivityViewModel extends ViewModel{

    public static final String LOG_TAG = MainActivity.class.getSimpleName();

    public MainActivityViewModel(Activity activity) {
        super(activity);
        Log.d(LOG_TAG, "Das Datenquellen-Objekt wird angelegt.");
        dataSource = new ShoppingMemoRepository(activity.getApplicationContext());
    }

    private ShoppingMemoRepository dataSource;

    public void openDatabase() {
        Log.d(LOG_TAG, "Die Datenquelle wird geöffnet.");
        dataSource.open();
    }

    public void closeDatabase() {
        Log.d(LOG_TAG, "Die Datenquelle wird geschlossen.");
        dataSource.close();
    }

    public void createShoppingMemo(String product, int quantity, float price) {
        dataSource.createShoppingMemo(product, quantity, price);
    }

    public List<ShoppingMemo> getAllShoppingMemos() {
        return dataSource.getAllShoppingMemos();
    }
}
