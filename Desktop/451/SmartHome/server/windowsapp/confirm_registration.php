<?php
	include "../database_connect.php";
	$confirm = $_GET["confirm"];
	$sql = "UPDATE users SET email_confirmed=1 WHERE email_confirm_text='$confirm'";
	$result = $conn->query($sql);
	if($result)
		die("Успешно се регистрирахте. Вече можете да влезете в акаунта си.");
	else
		die("Не съществува такъв идентификационен код, моля опитайте отново.");
?>