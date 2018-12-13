package de.bib.dozvjg.probeklausur.framework;

import android.app.Activity;
import android.app.Application;

public class ViewModel {

    public ViewModel(Activity activity) {
           checkApplication(activity);
    }

    private static Application checkApplication(Activity activity) {
        Application application = activity.getApplication();
        if (application == null) {
            throw new IllegalStateException("Your activity/fragment is not yet attached to "
                    + "Application. You can't request ViewModel before onCreate call.");
        }
        return application;
    }
}
