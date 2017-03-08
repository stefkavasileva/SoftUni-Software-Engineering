<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Fifty Shades of Grey </title>
    <style>
        div {
            display: inline-block;
            margin: 5px;
            width: 20px;
            height: 20px;
        }
    </style>
</head>
<body>
<?php

for ($i = 0; $i < 5; $i++){
    $grey= 51 * $i;
    for ($j = 0; $j < 10; $j++) {?>
        <div style="background-color:rgb(<?=$grey?>,<?= $grey?>,<?=$grey?>)"></div>
        <?php
        $grey+=5;
    } ?>
   <br/>
    <?php
}
?>
</body>
</html>