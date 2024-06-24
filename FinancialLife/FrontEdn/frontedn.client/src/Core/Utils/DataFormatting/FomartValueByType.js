/**
 * Formata um valor de entrada com base no tipo de dado esperado.
 * @param {string} type Tipo do campo (por exemplo, 'number', 'date', 'email', 'checkbox')
 * @param {string} value Valor do campo
 * @return {*} Valor formatado
 */
function formatValueByType(type, value) {
    switch (type) {
        case 'number':
            // Converte para Number ou retorna null se a string estiver vazia
            return value === "" ? null : Number(value);
        default:
            // Para todos os outros tipos, retorna o valor como está
            return value;
    }
}

export default formatValueByType;