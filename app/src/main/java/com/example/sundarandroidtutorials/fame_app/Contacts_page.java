package com.example.sundarandroidtutorials.fame_app;

import android.content.DialogInterface;
import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.ArrayAdapter;
import android.app.ListActivity;
import android.os.Bundle;
import android.widget.ArrayAdapter;
import android.widget.ListView;
import android.widget.Toast;

public class Contacts_page extends ListActivity {
    String[] listItems = {"Darryl Wiley", "Math tutor ", "John Smith", "Jane Doe"};
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_contacts_page);
        setListAdapter(new ArrayAdapter(this,  android.R.layout.simple_list_item_1, listItems));
    }

    @Override
    protected void onListItemClick(ListView l, View v, int position, long id) {
        Intent intent = new Intent(getApplicationContext(), activity_message_list.class);
        startActivity(intent);
    }

}
