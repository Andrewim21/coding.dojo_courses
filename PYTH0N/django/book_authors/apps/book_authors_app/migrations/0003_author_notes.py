# -*- coding: utf-8 -*-
# Generated by Django 1.10 on 2017-11-14 00:11
from __future__ import unicode_literals

from django.db import migrations, models


class Migration(migrations.Migration):

    dependencies = [
        ('book_authors_app', '0002_auto_20171114_0003'),
    ]

    operations = [
        migrations.AddField(
            model_name='author',
            name='notes',
            field=models.TextField(default=0, max_length=100),
            preserve_default=False,
        ),
    ]
