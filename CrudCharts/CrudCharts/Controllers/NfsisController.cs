using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CrudCharts.Models;

namespace CrudCharts.Controllers
{
    public class NfsisController : Controller
    {
        private readonly TreinamentoContext _context;

        public NfsisController(TreinamentoContext context)
        {
            _context = context;
        }

        // GET: Nfsis
        public async Task<IActionResult> Index()
        {
            var treinamentoContext = _context.Nfsi.Include(n => n.CdContaNavigation).Include(n => n.Nfsc);
            return View(await treinamentoContext.ToListAsync());
        }

        // GET: Nfsis/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nfsi = await _context.Nfsi
                .Include(n => n.CdContaNavigation)
                .Include(n => n.Nfsc)
                .FirstOrDefaultAsync(m => m.CdFilial == id);
            if (nfsi == null)
            {
                return NotFound();
            }

            return View(nfsi);
        }

        // GET: Nfsis/Create
        public IActionResult Create()
        {
            ViewData["CdConta"] = new SelectList(_context.CxaConta, "CdConta", "CdCompleto");
            ViewData["CdFilial"] = new SelectList(_context.Nfsc, "CdFilial", "FlIgnorarCxaCta");
            return View();
        }

        // POST: Nfsis/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CdFilial,NrDocumento,NrSequencia,CdProdserv,NmProdserv,FlServico,QtProduto,VlBruto,PcDesconto,VlLiquido,VlTotal,PrecoMinimo,CdFuncionario,DtEmissao,PesoLiquido,CdCancelamento,Cst,PcRedBaseIcm,AlicIcm,AlicIcmSubst,AlicIpi,AlicIss,VlBaseIcm,VlIcm,VlIcmSubst,VlIpi,VlIss,FlTributacaoInf,VlBaseComissao,VlComissao,PcComissao,FlComissaoInf,Compl,DtAtz,Un,FlControlarEstoque,PlacaVeiculo,Kilometragem,FlClassfiscal,CdConta,VlIssSubst,FlComposto,Composicao,VlBaseIcmSubst,VlFreteRateado,AlicUfDestino,Cfop,VlDesconto,VlDescontoRateado,VlAcrescimoRateado,VlSeguroRateado,VlContabil,VlOutros,VlIsento,AlicPis,VlBasePis,VlPis,AlicCofins,VlBaseCofins,VlCofins,VlBaseIss,VlBaseIpi,Iat,PcAcrescimo,PcRedBaseIcmProprioSt,PcRedBaseIcmSubst,AlicIcmProprioSt,VlBaseIcmProprioSt,VlIcmProprioSt,VlAcrescimo,FatorConversao,QtVenda,UnVenda,VlLiquidoVenda,CstIpi,CstPis,CstCofins,TpOperacaoVeicNovo,VlIcmFrete,ConhecimentoVlFrete,VlBaseIcmSubstAnt,VlIcmSubstAnt,NrSequenciaOsOri,FlSomaTotal,HashNfsiR5,VlIcmSubstDev,VlBaseIcmSubstDev,AlicIcmSubstDev,PcRedBaseIcmSubstDev,VlBaseIpiDev,VlIpiDev,AlicIpiDev,MvaDev,CdFci,AlicCsll,AlicIrrf,VlBaseCsll,VlCsll,VlBaseIr,VlIr,VlTribNacional,VlTribImportado,VlTribEstadual,VlTribMunicipal,VlBaseInss,VlInss,NrSequenciaDev,NmCest,NmClassFiscal,CdPedComp,NrItemPedComp,UnTrib,VlTrib,QtTrib,PcFcp,VlFcp,VlBaseFcp,VlBaseFcpSt,PcFcpSt,VlFcpSt,VlFcpStRetido,PcFcpStRetido,VlBaseFcpStRetido,VlBaseFcpUfDestino,PcFcpUfDestino,VlFcpUfDestino,VlBaseUfDestino,PcIcmsUfDestino,PcIcmsInterno,PcIcmsInternoPartilha,VlIcmsUfDestino,VlIcmsUfRemetente")] Nfsi nfsi)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nfsi);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CdConta"] = new SelectList(_context.CxaConta, "CdConta", "CdCompleto", nfsi.CdConta);
            ViewData["CdFilial"] = new SelectList(_context.Nfsc, "CdFilial", "FlIgnorarCxaCta", nfsi.CdFilial);
            return View(nfsi);
        }

        // GET: Nfsis/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nfsi = await _context.Nfsi.FindAsync(id);
            if (nfsi == null)
            {
                return NotFound();
            }
            ViewData["CdConta"] = new SelectList(_context.CxaConta, "CdConta", "CdCompleto", nfsi.CdConta);
            ViewData["CdFilial"] = new SelectList(_context.Nfsc, "CdFilial", "FlIgnorarCxaCta", nfsi.CdFilial);
            return View(nfsi);
        }

        // POST: Nfsis/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CdFilial,NrDocumento,NrSequencia,CdProdserv,NmProdserv,FlServico,QtProduto,VlBruto,PcDesconto,VlLiquido,VlTotal,PrecoMinimo,CdFuncionario,DtEmissao,PesoLiquido,CdCancelamento,Cst,PcRedBaseIcm,AlicIcm,AlicIcmSubst,AlicIpi,AlicIss,VlBaseIcm,VlIcm,VlIcmSubst,VlIpi,VlIss,FlTributacaoInf,VlBaseComissao,VlComissao,PcComissao,FlComissaoInf,Compl,DtAtz,Un,FlControlarEstoque,PlacaVeiculo,Kilometragem,FlClassfiscal,CdConta,VlIssSubst,FlComposto,Composicao,VlBaseIcmSubst,VlFreteRateado,AlicUfDestino,Cfop,VlDesconto,VlDescontoRateado,VlAcrescimoRateado,VlSeguroRateado,VlContabil,VlOutros,VlIsento,AlicPis,VlBasePis,VlPis,AlicCofins,VlBaseCofins,VlCofins,VlBaseIss,VlBaseIpi,Iat,PcAcrescimo,PcRedBaseIcmProprioSt,PcRedBaseIcmSubst,AlicIcmProprioSt,VlBaseIcmProprioSt,VlIcmProprioSt,VlAcrescimo,FatorConversao,QtVenda,UnVenda,VlLiquidoVenda,CstIpi,CstPis,CstCofins,TpOperacaoVeicNovo,VlIcmFrete,ConhecimentoVlFrete,VlBaseIcmSubstAnt,VlIcmSubstAnt,NrSequenciaOsOri,FlSomaTotal,HashNfsiR5,VlIcmSubstDev,VlBaseIcmSubstDev,AlicIcmSubstDev,PcRedBaseIcmSubstDev,VlBaseIpiDev,VlIpiDev,AlicIpiDev,MvaDev,CdFci,AlicCsll,AlicIrrf,VlBaseCsll,VlCsll,VlBaseIr,VlIr,VlTribNacional,VlTribImportado,VlTribEstadual,VlTribMunicipal,VlBaseInss,VlInss,NrSequenciaDev,NmCest,NmClassFiscal,CdPedComp,NrItemPedComp,UnTrib,VlTrib,QtTrib,PcFcp,VlFcp,VlBaseFcp,VlBaseFcpSt,PcFcpSt,VlFcpSt,VlFcpStRetido,PcFcpStRetido,VlBaseFcpStRetido,VlBaseFcpUfDestino,PcFcpUfDestino,VlFcpUfDestino,VlBaseUfDestino,PcIcmsUfDestino,PcIcmsInterno,PcIcmsInternoPartilha,VlIcmsUfDestino,VlIcmsUfRemetente")] Nfsi nfsi)
        {
            if (id != nfsi.CdFilial)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nfsi);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NfsiExists(nfsi.CdFilial))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["CdConta"] = new SelectList(_context.CxaConta, "CdConta", "CdCompleto", nfsi.CdConta);
            ViewData["CdFilial"] = new SelectList(_context.Nfsc, "CdFilial", "FlIgnorarCxaCta", nfsi.CdFilial);
            return View(nfsi);
        }

        // GET: Nfsis/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nfsi = await _context.Nfsi
                .Include(n => n.CdContaNavigation)
                .Include(n => n.Nfsc)
                .FirstOrDefaultAsync(m => m.CdFilial == id);
            if (nfsi == null)
            {
                return NotFound();
            }

            return View(nfsi);
        }

        // POST: Nfsis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var nfsi = await _context.Nfsi.FindAsync(id);
            _context.Nfsi.Remove(nfsi);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NfsiExists(int id)
        {
            return _context.Nfsi.Any(e => e.CdFilial == id);
        }
    }
}
