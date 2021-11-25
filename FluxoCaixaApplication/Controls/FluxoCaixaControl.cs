using FluxoCaixaApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluxoCaixaApplication.Controls
{
    public class FluxoCaixaControl 
    {
        private static FluxoCaixaControl _instance;

        private FluxoCaixaControl(){}

        public static FluxoCaixaControl getInstance()
        {
            if (_instance == null)
                _instance = new FluxoCaixaControl();
            return _instance;
        }     
        public (bool, string) Gravar (Caixa caixa,char tipo,decimal valor, string motivo)
        {
            bool sucesso = false;
            string msg = "";
            int lines = 0;

            if (caixa.Status)
            {
                AcertoCaixa acertoCx = new AcertoCaixa()
                {
                    Data = DateTime.Now,
                    Tipo = tipo,
                    Valor= valor,
                    Motivo = motivo
                };

                if (acertoCx.Valor > 0)
                    if (char.ToLower(acertoCx.Tipo) == 'r') // retirada 
                    {
                        if (acertoCx.Valor <= caixa.SaldoFinal)
                        {
                            if (!String.IsNullOrEmpty(acertoCx.Motivo)
                                && !String.IsNullOrWhiteSpace(acertoCx.Motivo))
                            {
                                (lines,msg) = acertoCx.Gravar();

                                if(lines > 0)
                                {
                                    caixa.SaldoFinal -= acertoCx.Valor;
                                    (lines, msg) = caixa.Gravar();
                                    if (lines > 0)
                                    {
                                        MovimentoCaixa movCaixa = new MovimentoCaixa()
                                        {
                                            Acerto = acertoCx,
                                            Caixa = caixa,
                                            Valor = acertoCx.Valor,
                                            Tipo = acertoCx.Tipo
                                        };
                                        (lines, msg) = movCaixa.Gravar();
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        (lines, msg) = acertoCx.Gravar();
                        if (lines > 0)
                        {
                            caixa.SaldoFinal += acertoCx.Valor;
                            (lines, msg) = caixa.Gravar();

                            if (lines > 0)
                            {
                                MovimentoCaixa movCaixa = new MovimentoCaixa()
                                {
                                    Acerto = acertoCx,
                                    Caixa = caixa,
                                    Valor = acertoCx.Valor,
                                    Tipo = acertoCx.Tipo
                                };
                                (lines, msg) = movCaixa.Gravar();
                            }
                        }
                    }
                if (lines > 0)
                {
                    sucesso = true;
                    msg = "Movimentação registrada com sucesso.";
                }  
            }
            return (sucesso, msg);
        }
    }
}
