<?php
	include "database_connect.php";
	$username = $_POST["username"];
	$password = $_POST["password"];
	$sql = "SELECT id FROM users WHERE username = '$username' AND password = '$password'";
	$result = $conn->query($sql);
	if($result->num_rows == 0)
		die("Invalid userdata");
	$row = $result->fetch_assoc();
	$user_id = $row["id"];
	$sql = "SELECT device_name FROM devices WHERE user_id = '$user_id'";
	$result = $conn->query($sql);
	if(!$result)
		die($conn->error);
	$resp = "";
	foreach ($result as $row)
		$resp .= $row["device_name"].",";
	$resp = substr($resp, 0, -1);
	die($resp);
?>