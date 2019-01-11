package com.example.android.notificationchannels;

public class Post
{
    public String uid, firstName, lastName, date, time, body;

    public Post()
    {

    }

    public Post(String uid, String firstName, String lastName, String date, String time, String body) {
        this.uid = uid;
        this.firstName = firstName;
        this.lastName = lastName;
        this.date = date;
        this.time = time;
        this.body = body;
    }

    public String getUid() {
        return uid;
    }

    public void setUid(String uid) {
        this.uid = uid;
    }

    public String getFirstName() {
        return firstName;
    }

    public void setFirstName(String firstName) {
        this.firstName = firstName;
    }

    public String getLastName() {
        return lastName;
    }

    public void setLastName(String lastName) {
        this.lastName = lastName;
    }

    public String getDate() {
        return date;
    }

    public void setDate(String date) {
        this.date = date;
    }

    public String getTime() {
        return time;
    }

    public void setTime(String time) {
        this.time = time;
    }

    public String getBody() {
        return body;
    }

    public void setBody(String body) {
        this.body = body;
    }
}
