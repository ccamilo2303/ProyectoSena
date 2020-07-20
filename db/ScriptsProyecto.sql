insert into autores values(1, 'Mario Mendoza');
insert into generos values(1, 'Romance contemporáneo');
insert into revistas_libros values(172, '01/01/1992', 'La ciudad de los umbrales es una novela del escritor colombiano Mario Mendoza que ha sido catalogada como descarnadamente descriptiva, la novela le confiere al lector una habilidad de interpretación', 'Editorial Seix Barral', 'La ciudad de los umbrales');
insert into libros values(1, 1, 1);

insert into tipo_revistas values(1, 'Automovilístico');
insert into revistas_libros values(50, getdate(), 'Revista enfocada a la actualidad automovilística', 'El Tiempo', 'Revista Motor');
insert into revistas values(1, 2);

insert into estudiantes values('12300123', 'José', 'Blanco Álvarez');
insert into estudiantes_revistas_libros values(1, 1);