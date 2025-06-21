--------------------------- INSERT CLIENTES --------------------

SET @rta = 0;

-- -----------------------------
-- 🧍 No Socios
-- -----------------------------
CALL AltaCliente(
    'Ana', 'Martínez', '40000001', '3794550011', 'ana.martinez@gmail.com',
    1, '2025-06-01', 0, NULL, NULL, @rta
);
SELECT @rta;

CALL AltaCliente(
    'Carlos', 'Sosa', '40000002', '3794550012', 'carlos.sosa@gmail.com',
    1, '2025-06-01', 0, NULL, NULL, @rta
);
SELECT @rta;

CALL AltaCliente(
    'Elena', 'Ramírez', '40000003', '3794550013', 'elena.ramirez@gmail.com',
    1, '2025-06-01', 0, NULL, NULL, @rta
);
SELECT @rta;

CALL AltaCliente(
    'Jorge', 'Torres', '40000004', '3794550014', 'jorge.torres@gmail.com',
    1, '2025-06-01', 0, NULL, NULL, @rta
);
SELECT @rta;

CALL AltaCliente(
    'Valeria', 'Acosta', '40000005', '3794550015', 'valeria.acosta@gmail.com',
    1, '2025-06-01', 0, NULL, NULL, @rta
);
SELECT @rta;

-- -----------------------------
-- 👥 Socios
-- -----------------------------
CALL AltaCliente(
    'Lucas', 'Gutiérrez', '40000006', '3794550021', 'lucas.gutierrez@gmail.com',
    1, '2025-06-01', 1, 1, '2025-07-01', @rta
);
SELECT @rta;

CALL AltaCliente(
    'Marina', 'Díaz', '40000007', '3794550022', 'marina.diaz@gmail.com',
    1, '2025-06-01', 1, 1, '2025-07-01', @rta
);
SELECT @rta;

CALL AltaCliente(
    'Gonzalo', 'Vega', '40000008', '3794550023', 'gonzalo.vega@gmail.com',
    1, '2025-06-01', 1, 1, '2025-07-01', @rta
);
SELECT @rta;

CALL AltaCliente(
    'Carla', 'López', '40000009', '3794550024', 'carla.lopez@gmail.com',
    1, '2025-06-01', 1, 0, '2025-07-01', @rta
);
SELECT @rta;

CALL AltaCliente(
    'Emiliano', 'Paz', '40000010', '3794550025', 'emiliano.paz@gmail.com',
    1, '2025-06-01', 1, 1, '2025-07-01', @rta
);
SELECT @rta;


-- Socios, cuota por vencer hoy

CALL AltaCliente(
  'Juan', 'Pérez', '12345678', '1111111', 'juan@gmail.com',
  1, '2025-05-20', 1, 1, CURDATE(), @rta
);
SELECT @rta;

CALL AltaCliente(
  'María', 'Gómez', '23456789', '2222222', 'maria@gmail.com',
  1, '2025-05-20', 1, 1, CURDATE(), @rta
);
SELECT @rta;

CALL AltaCliente(
  'Carlos', 'Sosa', '56789012', '5555555', 'carlos@gmail.com',
  0, '2025-05-20', 1, 1, CURDATE(), @rta
);
SELECT @rta;

CALL AltaCliente(
  'Lucía', 'Ramírez', '67890123', '6666666', 'lucia@gmail.com',
  1, '2025-05-20', 1, 1, CURDATE(), @rta
);
SELECT @rta;

-- Socios, cuota vencida

CALL AltaCliente(
  'Marlene', 'Torres', '32100001', '345422332', 'marlene@gmail.com',
  1, '2025-05-01', 1, 1, '2025-06-01', @rta
);
SELECT @rta;

CALL AltaCliente(
  'Carina', 'Carega', '32100002', '434343434', 'carina@gmail.com',
  1, '2025-05-01', 1, 1, '2025-06-01', @rta
);
SELECT @rta;

CALL AltaCliente(
  'Pedro', 'Lopez', '32100003', '342221111', 'pedro@gmail.com',
  1, '2025-05-01', 1, 1, '2025-06-01', @rta
);
SELECT @rta;

-- Socios, ficha medica no entregada

CALL AltaCliente(
  'Tatiana', 'Cerdeño', '32100008', '65544556', 'tati@gmail.com',
  0, '2025-06-01', 1, 1, '2025-07-01', @rta
);
SELECT @rta;

CALL AltaCliente(
  'Leyla', 'Capristo', '32100009', '7566756756', 'leyla@gmail.com',
  0, '2025-06-01', 1, 1, '2025-07-01', @rta
);
SELECT @rta;

CALL AltaCliente(
  'Marina', 'Vazquez', '32100007', '242424234', 'mari@gmail.com',
  0, '2025-06-01', 1, 1, '2025-07-01', @rta
);
SELECT @rta;

-- No Socios, ficha medica no entregada

CALL AltaCliente(
    'Valeria', 'Benitez', '35777888', '432423424', 'val@gmail.com',
    0, '2025-06-01', 0, NULL, NULL, @rta
);
SELECT @rta;

CALL AltaCliente(
    'Samantha', 'Cirio', '32111111', '32432434', 'sami@gmail.com',
    0, '2025-06-01', 0, NULL, NULL, @rta
);
SELECT @rta;






