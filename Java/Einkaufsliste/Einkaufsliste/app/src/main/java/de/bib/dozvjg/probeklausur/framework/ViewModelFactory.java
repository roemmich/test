package de.bib.dozvjg.probeklausur.framework;

import android.app.Activity;

import java.lang.reflect.Constructor;
import java.lang.reflect.InvocationTargetException;
import java.util.HashMap;

public enum ViewModelFactory {
    INSTANCE;

    private HashMap<String, ViewModel> mExistingViewModels = new HashMap<String,ViewModel>();

    public ViewModel getViewModel(Activity parent, Class viewModelClass) {
        if(!mExistingViewModels.containsKey(parent)) {
            try {
                Constructor constructor = viewModelClass.getConstructor(new Class[]{Activity.class});
                Object [] paramValuesSub = {  parent.getApplicationContext() };
                ViewModel newInstance = (ViewModel)constructor.newInstance(parent);
                mExistingViewModels.put(parent.getComponentName().toString(), newInstance);
            } catch (IllegalAccessException e) {
                e.printStackTrace();
            } catch (InstantiationException e) {
                e.printStackTrace();
            } catch (NoSuchMethodException e) {
                e.printStackTrace();
            } catch (InvocationTargetException e) {
                e.printStackTrace();
            }
        }
        return mExistingViewModels.get(parent.getComponentName().toString());
    }
}
