﻿using System.Security.Claims;
using System;

public class Node<T>
{
    public T Item { get; set; }
    public Node<T> Next; { get; set; }
    public Node(T item, Node<T> next){
    }

}//EOC
