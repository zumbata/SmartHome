<?php
	include "../database_connect.php";
	$username = $_POST["username"];
	$password = $_POST["password"];
	$name = $_POST["name"];
	$email = $_POST["email"];
	$sql = "SELECT id FROM users WHERE username = '$username'";
	$result = $conn->query($sql);
	if($result->num_rows>0)
		die("1");
	$sql = "SELECT id FROM users WHERE email = '$email'";
	$result = $conn->query($sql);
	if($result->num_rows>0)
		die("2");
	$text = "";
	do
	{
		$chars = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
    	$charslen = strlen($chars);
	    for ($i = 0; $i < 10; $i++) {
	        $text .= $chars[mt_rand(0, $charslen - 1)];
	    }
		$sql = "SELECT id FROM users WHERE email_confirm_text = $text";
		$result = $conn->query($sql);
	}
	while($result->num_rows>0);
	$sql = "
	INSERT INTO users (name, email, username, password, email_confirm_text, email_confirmed) VALUES ('$name', '$email', '$username', '$password', '$text', '0')
	";
	$result = $conn->query($sql);
	if(!$result)
		die($conn->error);
	$mail="Click on the link to confirm your registration: http://www.smarthome.dimitarkostov.eu/windowsapp/confirm_registration.php?confirm=".$text." \n Have a great day!";
	$headers = "From: admin@smarthome.dimitarkostov.eu\r\n";
	mail($email, "SmartHome E-mail confirmation", $mail, $headers);
	die("3");
?>