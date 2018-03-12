<?php
	include "database_connect.php";
	$username = $_GET["username"];
	$device_name = $_GET["device_name"];
	$temp_cel = $_GET["temp_cel"];
	$temp_far = $_GET["temp_far"];
	$heat_index_cel = $_GET["heat_index_cel"];
	$heat_index_far = $_GET["heat_index_far"];
	$hum = $_GET["hum"];
	$lux = $_GET["lux"];
	$gas_ppm = $_GET["gas_ppm"];
	$sql = "SELECT id FROM users WHERE username = '$username'";
	$result = $conn->query($sql);
	if($result->num_rows == 0)
		die("1");
	$row = $result->fetch_assoc();
	$user_id = $row["id"];
	$sql = "SELECT id FROM devices WHERE device_name = '$device_name'";
	$result = $conn->query($sql);
	if($result->num_rows == 0)
		die("1");
	$row = $result->fetch_assoc();
	$device_id = $row["id"];
	$sql = "SELECT * FROM sensors_data WHERE user_id = '$user_id' AND device_id = '$device_id'";
	$result = $conn->query($sql);
	if($result->num_rows == 0)
	{
		$sql = "INSERT INTO sensors_data (user_id, temp_cel, temp_far, heat_index_cel, heat_index_far, hum, lux, gas_ppm) VALUES ('$user_id', '$temp_cel', '$temp_far', '$heat_index_cel', '$heat_index_far', '$hum', '$lux', '$gas_ppm')";
		$result  = $conn->query($sql);
		if(!$result)
			die($conn->error);
		die("2");
	}
	$sql = "UPDATE sensors_data SET user_id='$user_id', temp_cel='$temp_cel', temp_far='$temp_far', heat_index_cel='$heat_index_cel', heat_index_far='$heat_index_far', hum='$hum', lux='$lux', gas_ppm='$gas_ppm' WHERE user_id = '$user_id'";
	$result = $conn->query($sql);
	if(!$result)
		die($conn->error);
	die("3");
?>