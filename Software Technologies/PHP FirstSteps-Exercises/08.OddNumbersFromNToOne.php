<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title> Odd Numbers from N to One  </title>

</head>
<body>
<form>
    N: <input type="text" name="num" />
    <input type="submit" />
</form>
<?php
if (isset($_GET['num'])){
    $number=intval($_GET['num']);
    $numbers;
    for ($i =$number ; $i> 0;$i--){
        if ($i %2 !=0){
            $numbers[]=$i;
        }
    }

    echo join(' ',$numbers);
}
?>
</body>
</html>