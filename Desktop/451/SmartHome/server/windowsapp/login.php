<?php
	include "../database_connect.php";
	$username = $_POST["username"];
	$password = $_POST["password"];
	$sql = "SELECT password, email, name, email_confirmed FROM users WHERE username = '$username'";
	$result = $conn->query($sql);
	if($result->num_rows == 0)
		die("1");
	$row = $result->fetch_assoc();
	$db_password = $row["password"];
	$name = $row["name"];
	$email = $row["email"];
	$cnf = $row["email_confirmed"];
	if($cnf == 0)
		die("2");
	if($password != $db_password)
		die("3");
	die("4 ".$email."\n".$name);
?>
