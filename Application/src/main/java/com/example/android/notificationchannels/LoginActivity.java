package com.example.android.notificationchannels;

import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.support.annotation.NonNull;
import android.text.TextUtils;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ProgressBar;
import android.widget.TextView;
import android.widget.Toast;

import com.google.android.gms.tasks.OnCompleteListener;
import com.google.android.gms.tasks.Task;
import com.google.firebase.auth.AuthResult;
import com.google.firebase.auth.FirebaseAuth;
import com.google.firebase.auth.FirebaseUser;

public class LoginActivity extends Activity {

    private EditText Email;
    private EditText Password;
    private TextView Info;
    private Button Login;
    private TextView CreateAccount;

    private FirebaseAuth mAuth;

    private ProgressBar loadingBar;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_login);

        Email = findViewById(R.id.et_email);
        Password = findViewById(R.id.et_password);
        Login = findViewById(R.id.btn_login);
        CreateAccount = findViewById(R.id.tv_create_account);

        mAuth = FirebaseAuth.getInstance();

        loadingBar = findViewById(R.id.loginProgress);

        Login.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                validate(Email.getText().toString(), Password.getText().toString());
            }
        });

        CreateAccount.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                sendToCreateAccount();
            }
        });
    }

    @Override
    protected void onStart() {
        super.onStart();

        FirebaseUser currentUser = mAuth.getCurrentUser();

        if(currentUser != null)
            sendToMain();
    }

    private void validate (String userEmail, String userPassword)
    {
        if(TextUtils.isEmpty(userEmail))
        {
            Toast.makeText(this, "Please include your email", Toast.LENGTH_SHORT).show();
        }
        else if(TextUtils.isEmpty(userPassword))
        {
            Toast.makeText(this, "Please include your password", Toast.LENGTH_SHORT).show();
        }
        else
        {
            loadingBar.setVisibility(ProgressBar.VISIBLE);

            mAuth.signInWithEmailAndPassword(userEmail, userPassword)
                    .addOnCompleteListener(new OnCompleteListener<AuthResult>() {
                        @Override
                        public void onComplete(@NonNull Task<AuthResult> task) {
                            if(task.isSuccessful())
                            {
                                Toast.makeText(LoginActivity.this, "Logged in successfully", Toast.LENGTH_SHORT).show();
                                sendToMain();
                                loadingBar.setVisibility(ProgressBar.INVISIBLE);
                            }
                            else
                            {
                                String message = task.getException().getMessage();
                                Toast.makeText(LoginActivity.this, "Error occured: " + message, Toast.LENGTH_SHORT).show();
                                loadingBar.setVisibility(ProgressBar.INVISIBLE);
                            }
                        }
                    });
        }
    }

    private void sendToMain() {
        Intent mainIntent = new Intent(LoginActivity.this, MainActivity.class);
        mainIntent.addFlags(Intent.FLAG_ACTIVITY_NEW_TASK | Intent.FLAG_ACTIVITY_CLEAR_TASK);
        startActivity(mainIntent);
        finish();
    }
    private void sendToCreateAccount() {
        Intent createAccountIntent = new Intent(LoginActivity.this, NewAccountActivity.class);
        startActivity(createAccountIntent);
    }
}
