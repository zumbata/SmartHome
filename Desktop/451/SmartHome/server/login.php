<?php
	include "database_connect.php";
	$username = $_POST["username"];
	$password = $_POST["password"];
	$sql = "SELECT id, password, email, name, email_confirmed FROM users WHERE username = '$username'";
	$result = $conn->query($sql);
	if($result->num_rows == 0)
		die("Invalid username");
	$row = $result->fetch_assoc();
	$user_id = $row["id"];
	$db_password = $row["password"];
	$name = $row["name"];
	$email = $row["email"];
	$cnf = $row["email_confirmed"];
	if($cnf == 0)
		die("E-mail not confirmed");
	if($password != $db_password)
		die("Invalid password");
	die("Success");
?>
