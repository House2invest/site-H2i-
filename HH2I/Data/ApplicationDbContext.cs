﻿namespace House2Invest.Data
{
    using House2Invest;
    using House2Invest.Models;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    public class ApplicationDbContext : IdentityDbContext<UsuarioApp>
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ParameterExpression expression = Expression.Parameter((Type) typeof(House2Invest.Models.AppConfiguracoes_Aplicativo), "x");
            Expression[] expressionArray1 = new Expression[] { (Expression) Expression.Property((Expression) expression, (MethodInfo) methodof(House2Invest.Models.AppConfiguracoes_Aplicativo.get_CPFCNPJ)) };
            MemberInfo[] infoArray1 = new MemberInfo[] { methodof(<>f__AnonymousType4<string>.get_CPFCNPJ, <>f__AnonymousType4<string>) };
            ParameterExpression[] expressionArray2 = new ParameterExpression[] { expression };
            modelBuilder.Entity<House2Invest.Models.AppConfiguracoes_Aplicativo>().HasIndex(Expression.Lambda<Func<House2Invest.Models.AppConfiguracoes_Aplicativo, object>>((Expression) Expression.New((ConstructorInfo) methodof(<>f__AnonymousType4<string>..ctor, <>f__AnonymousType4<string>), expressionArray1, infoArray1), expressionArray2)).IsUnique(true);
            expression = Expression.Parameter((Type) typeof(House2Invest.Models.AppConfiguracoes_Aplicativo), "x");
            Expression[] expressionArray3 = new Expression[] { (Expression) Expression.Property((Expression) expression, (MethodInfo) methodof(House2Invest.Models.AppConfiguracoes_Aplicativo.get_Empresa)) };
            MemberInfo[] infoArray2 = new MemberInfo[] { methodof(<>f__AnonymousType5<string>.get_Empresa, <>f__AnonymousType5<string>) };
            ParameterExpression[] expressionArray4 = new ParameterExpression[] { expression };
            modelBuilder.Entity<House2Invest.Models.AppConfiguracoes_Aplicativo>().HasIndex(Expression.Lambda<Func<House2Invest.Models.AppConfiguracoes_Aplicativo, object>>((Expression) Expression.New((ConstructorInfo) methodof(<>f__AnonymousType5<string>..ctor, <>f__AnonymousType5<string>), expressionArray3, infoArray2), expressionArray4)).IsUnique(true);
            expression = Expression.Parameter((Type) typeof(House2Invest.Models.AppConfiguracoes), "x");
            Expression[] expressionArray5 = new Expression[] { (Expression) Expression.Property((Expression) expression, (MethodInfo) methodof(House2Invest.Models.AppConfiguracoes.get_Descricao)) };
            MemberInfo[] infoArray3 = new MemberInfo[] { methodof(<>f__AnonymousType6<string>.get_Descricao, <>f__AnonymousType6<string>) };
            ParameterExpression[] expressionArray6 = new ParameterExpression[] { expression };
            modelBuilder.Entity<House2Invest.Models.AppConfiguracoes>().HasIndex(Expression.Lambda<Func<House2Invest.Models.AppConfiguracoes, object>>((Expression) Expression.New((ConstructorInfo) methodof(<>f__AnonymousType6<string>..ctor, <>f__AnonymousType6<string>), expressionArray5, infoArray3), expressionArray6)).IsUnique(true);
            expression = Expression.Parameter((Type) typeof(House2Invest.Models.AppConfiguracoes), "x");
            Expression[] expressionArray7 = new Expression[] { (Expression) Expression.Property((Expression) expression, (MethodInfo) methodof(House2Invest.Models.AppConfiguracoes.get_URLExibicao)) };
            MemberInfo[] infoArray4 = new MemberInfo[] { methodof(<>f__AnonymousType7<string>.get_URLExibicao, <>f__AnonymousType7<string>) };
            ParameterExpression[] expressionArray8 = new ParameterExpression[] { expression };
            modelBuilder.Entity<House2Invest.Models.AppConfiguracoes>().HasIndex(Expression.Lambda<Func<House2Invest.Models.AppConfiguracoes, object>>((Expression) Expression.New((ConstructorInfo) methodof(<>f__AnonymousType7<string>..ctor, <>f__AnonymousType7<string>), expressionArray7, infoArray4), expressionArray8)).IsUnique(true);
            expression = Expression.Parameter((Type) typeof(House2Invest.Models.AppConfiguracoes), "x");
            Expression[] expressionArray9 = new Expression[] { (Expression) Expression.Property((Expression) expression, (MethodInfo) methodof(House2Invest.Models.AppConfiguracoes.get_Descricao)), (Expression) Expression.Property((Expression) expression, (MethodInfo) methodof(House2Invest.Models.AppConfiguracoes.get_URLExibicao)), (Expression) Expression.Property((Expression) expression, (MethodInfo) methodof(House2Invest.Models.AppConfiguracoes.get_AppConfiguracoes_AplicativoId)), (Expression) Expression.Property((Expression) expression, (MethodInfo) methodof(House2Invest.Models.AppConfiguracoes.get_AppConfiguracoes_AzureId)) };
            MemberInfo[] infoArray5 = new MemberInfo[] { methodof(<>f__AnonymousType8<string, string, int, int>.get_Descricao, <>f__AnonymousType8<string, string, int, int>), methodof(<>f__AnonymousType8<string, string, int, int>.get_URLExibicao, <>f__AnonymousType8<string, string, int, int>), methodof(<>f__AnonymousType8<string, string, int, int>.get_AppConfiguracoes_AplicativoId, <>f__AnonymousType8<string, string, int, int>), methodof(<>f__AnonymousType8<string, string, int, int>.get_AppConfiguracoes_AzureId, <>f__AnonymousType8<string, string, int, int>) };
            ParameterExpression[] expressionArray10 = new ParameterExpression[] { expression };
            modelBuilder.Entity<House2Invest.Models.AppConfiguracoes>().HasIndex(Expression.Lambda<Func<House2Invest.Models.AppConfiguracoes, object>>((Expression) Expression.New((ConstructorInfo) methodof(<>f__AnonymousType8<string, string, int, int>..ctor, <>f__AnonymousType8<string, string, int, int>), expressionArray9, infoArray5), expressionArray10)).IsUnique(true);
            expression = Expression.Parameter((Type) typeof(House2Invest.Models.AppPerfil), "x");
            Expression[] expressionArray11 = new Expression[] { (Expression) Expression.Property((Expression) expression, (MethodInfo) methodof(House2Invest.Models.AppPerfil.get_AppConfiguracoesId)) };
            MemberInfo[] infoArray6 = new MemberInfo[] { methodof(<>f__AnonymousType9<int>.get_AppConfiguracoesId, <>f__AnonymousType9<int>) };
            ParameterExpression[] expressionArray12 = new ParameterExpression[] { expression };
            modelBuilder.Entity<House2Invest.Models.AppPerfil>().HasIndex(Expression.Lambda<Func<House2Invest.Models.AppPerfil, object>>((Expression) Expression.New((ConstructorInfo) methodof(<>f__AnonymousType9<int>..ctor, <>f__AnonymousType9<int>), expressionArray11, infoArray6), expressionArray12)).IsUnique(true);
            foreach (IMutableForeignKey key in Enumerable.SelectMany<IMutableEntityType, IMutableForeignKey>(modelBuilder.get_Model().GetEntityTypes(), delegate (IMutableEntityType e) {
                return e.GetForeignKeys();
            }))
            {
                key.set_DeleteBehavior(1);
            }
            base.OnModelCreating(modelBuilder);
            foreach (IMutableEntityType type in modelBuilder.get_Model().GetEntityTypes())
            {
                foreach (IMutableProperty property in type.GetProperties())
                {
                    object[] customAttributes = property.get_PropertyInfo().GetCustomAttributes(typeof(EncryptedAttribute), false);
                    if (Enumerable.Any<object>(customAttributes))
                    {
                        MutablePropertyBaseExtensions.SetField(property, (Enumerable.First<object>(customAttributes) as EncryptedAttribute).FieldName);
                        MutablePropertyBaseExtensions.SetPropertyAccessMode(property, 0);
                    }
                }
            }
            House2Invest.Models.AppConfiguracoes_Aplicativo aplicativo1 = new House2Invest.Models.AppConfiguracoes_Aplicativo();
            aplicativo1.Bairro = "JD. NOSSA SENHORA DO CARMO";
            aplicativo1.Celular = "(11) 99881-4900";
            aplicativo1.CEP = "08275-010";
            aplicativo1.Cidade = "SAO PAULO";
            aplicativo1.Complemento = "";
            aplicativo1.CPFCNPJ = "14.581.834/0001-42";
            aplicativo1.EmailContato = "leandrodiascarvalho@hotmail.com";
            aplicativo1.EmailSuporte = "leandrodiascarvalho@hotmail.com";
            aplicativo1.EmailVendas = "leandrodiascarvalho@hotmail.com";
            aplicativo1.Empresa = "DEPOIS DA LINHA";
            aplicativo1.Estado = "SP";
            aplicativo1.Fone = "(11) 99881-4900";
            aplicativo1.FoneRecados = "(11) 99881-4900";
            aplicativo1.Id = 1;
            aplicativo1.LogotipoEmpresa = "/images/avatar-depois-da-linha.png";
            aplicativo1.Logradouro = "MATEUS MENDES PEREIRA, 312";
            aplicativo1.mailFrom = CriptografiaHelper.Encriptar("contato@house2invest.com.br", "", "");
            aplicativo1.mailToAdd = CriptografiaHelper.Encriptar("cristina.loschiavo@house2invest.com.br;jpmartins@house2invest.com.br", "", "");
            aplicativo1.smtpCredentialsEmail = CriptografiaHelper.Encriptar("contato@house2invest.com.br", "", "");
            aplicativo1.smtpCredentialsSenha = CriptografiaHelper.Encriptar("Senha@010203", "", "");
            aplicativo1.smtpEnableSsl = true;
            aplicativo1.smtpHost = CriptografiaHelper.Encriptar("smtp.gmail.com", "", "");
            aplicativo1.smtpPort = 0x24b;
            aplicativo1.smtpUseDefaultCredentials = false;
            aplicativo1.dumpSQLHost = CriptografiaHelper.Encriptar(@".\SQLEXPRESS", "", "");
            aplicativo1.dumpSQLUser = CriptografiaHelper.Encriptar("admh2i", "", "");
            aplicativo1.dumpSQLPass = CriptografiaHelper.Encriptar("SenhaAdm@125634", "", "");
            aplicativo1.temporizaLmiteMaximoOfertaSuspensa = CriptografiaHelper.Encriptar("30 DIA", "", "");
            aplicativo1.temporizaLmiteMaximoRevogaInvestimento = CriptografiaHelper.Encriptar("5 DIA", "", "");
            aplicativo1.temporizaLmiteMaximoCancelaInvestimento = CriptografiaHelper.Encriptar("7 DIA", "", "");
            House2Invest.Models.AppConfiguracoes_Aplicativo[] aplicativoArray1 = new House2Invest.Models.AppConfiguracoes_Aplicativo[] { aplicativo1 };
            modelBuilder.Entity<House2Invest.Models.AppConfiguracoes_Aplicativo>().HasData(aplicativoArray1);
            House2Invest.Models.AppConfiguracoes_Azure azure1 = new House2Invest.Models.AppConfiguracoes_Azure();
            azure1.Id = 1;
            azure1._azureblob_AccountKey = CriptografiaHelper.Encriptar("CyEzhD1y/7lXEtwgpAkYQeTqtI6X/9FjJjuHtQ8VE8xQymhxjj/xB8zW7Aa3D4boXdvUc94bUbz2E49rAkHr+g==", "", "");
            azure1._azureblob_AccountName = CriptografiaHelper.Encriptar("house2invest", "", "");
            azure1._azureblob_ContainerRaiz = CriptografiaHelper.Encriptar("house2invest", "", "");
            azure1.EnderecoArmazLocal = "";
            azure1.UsarSimuladorLocal = false;
            House2Invest.Models.AppConfiguracoes_Azure[] azureArray1 = new House2Invest.Models.AppConfiguracoes_Azure[] { azure1 };
            modelBuilder.Entity<House2Invest.Models.AppConfiguracoes_Azure>().HasData(azureArray1);
            House2Invest.Models.AppConfiguracoes configuracoes1 = new House2Invest.Models.AppConfiguracoes();
            configuracoes1.Id = 1;
            configuracoes1.AppConfiguracoes_AplicativoId = 1;
            configuracoes1.AppConfiguracoes_AzureId = 1;
            configuracoes1.Descricao = "Tema padr\x00e3o";
            configuracoes1.Tema = "_Layout";
            configuracoes1.URLExibicao = "padrao";
            configuracoes1.CaminhoAbsolutoTema = "";
            configuracoes1.NovosUsuarios = false;
            configuracoes1.NovosUsuarios_NivelADM = true;
            House2Invest.Models.AppConfiguracoes[] configuracoesArray1 = new House2Invest.Models.AppConfiguracoes[] { configuracoes1 };
            modelBuilder.Entity<House2Invest.Models.AppConfiguracoes>().HasData(configuracoesArray1);
            House2Invest.Models.AppPerfil perfil1 = new House2Invest.Models.AppPerfil();
            perfil1.Id = 1;
            perfil1.AppConfiguracoesId = 1;
            House2Invest.Models.AppPerfil[] perfilArray1 = new House2Invest.Models.AppPerfil[] { perfil1 };
            modelBuilder.Entity<House2Invest.Models.AppPerfil>().HasData(perfilArray1);
            IdentityRole role1 = new IdentityRole();
            role1.set_Id("59c39ee9-024a-41c1-bae8-7859879aa9f2");
            role1.set_Name("SIS");
            role1.set_NormalizedName("SIS");
            IdentityRole[] roleArray1 = new IdentityRole[14];
            roleArray1[0] = role1;
            IdentityRole role2 = new IdentityRole();
            role2.set_Id("d3f04340-133b-4fe5-964f-725cf3482cbb");
            role2.set_Name("ADM");
            role2.set_NormalizedName("ADM");
            roleArray1[1] = role2;
            IdentityRole role3 = new IdentityRole();
            role3.set_Id("730f160e-5178-4f3c-a955-2c12abc4d1f9");
            role3.set_Name("SUPERVISOR");
            role3.set_NormalizedName("SUPERVISOR");
            roleArray1[2] = role3;
            IdentityRole role4 = new IdentityRole();
            role4.set_Id("a59726df-21c5-44c8-96ba-a4a2244dea3c");
            role4.set_Name("ADMCONTA");
            role4.set_NormalizedName("ADMCONTA");
            roleArray1[3] = role4;
            IdentityRole role5 = new IdentityRole();
            role5.set_Id("ced87445-4121-45ff-b05e-6965f5014bc8");
            role5.set_Name("API");
            role5.set_NormalizedName("API");
            roleArray1[4] = role5;
            IdentityRole role6 = new IdentityRole();
            role6.set_Id("8f0a2fbc-ec7d-47e2-b307-0d5085e57275");
            role6.set_Name("MANUTAPP");
            role6.set_NormalizedName("MANUTAPP");
            roleArray1[5] = role6;
            IdentityRole role7 = new IdentityRole();
            role7.set_Id("e42f1601-ac85-4384-8fd4-f3c4345b56db");
            role7.set_Name("SUPORTE");
            role7.set_NormalizedName("SUPORTE");
            roleArray1[6] = role7;
            IdentityRole role8 = new IdentityRole();
            role8.set_Id("c91c9806-bd59-4a8e-ade6-13bc0427602c");
            role8.set_Name("COMUNIDADE");
            role8.set_NormalizedName("COMUNIDADE");
            roleArray1[7] = role8;
            IdentityRole role9 = new IdentityRole();
            role9.set_Id("257310a1-a0bf-4625-ae12-a31c2940e5af");
            role9.set_Name("FINANCEIRO");
            role9.set_NormalizedName("FINANCEIRO");
            roleArray1[8] = role9;
            IdentityRole role10 = new IdentityRole();
            role10.set_Id("acbfb305-1c76-4a54-8c40-36ff8ac5312e");
            role10.set_Name("MARKETING");
            role10.set_NormalizedName("MARKETING");
            roleArray1[9] = role10;
            IdentityRole role11 = new IdentityRole();
            role11.set_Id("eb7726bc-7c17-446c-a22a-72df87922494");
            role11.set_Name("MIDIAS");
            role11.set_NormalizedName("MIDIAS");
            roleArray1[10] = role11;
            IdentityRole role12 = new IdentityRole();
            role12.set_Id("99d47b3f-b8f7-435a-b6a0-7dd2e80f4d30");
            role12.set_Name("VENDA");
            role12.set_NormalizedName("VENDA");
            roleArray1[11] = role12;
            IdentityRole role13 = new IdentityRole();
            role13.set_Id("16b933cf-e693-47d5-9957-d217467d17a6");
            role13.set_Name("DESENVOLVEDOR");
            role13.set_NormalizedName("DESENVOLVEDOR");
            roleArray1[12] = role13;
            IdentityRole role14 = new IdentityRole();
            role14.set_Id("96c373b4-8cc5-4a63-9f9a-81884a5efe75");
            role14.set_Name("USU");
            role14.set_NormalizedName("USU");
            roleArray1[13] = role14;
            modelBuilder.Entity<IdentityRole>().HasData(roleArray1);
            PasswordHasher<UsuarioApp> hasher = new PasswordHasher<UsuarioApp>(null);
            UsuarioApp app1 = new UsuarioApp();
            app1.set_Id("b30b4d21-0f99-435e-acec-a2c672697b0f");
            app1.AppConfiguracoesId = 1;
            app1.Sistema_AcessoBloqueado = false;
            app1.set_UserName("adm@depoisdalinha.com.br");
            app1.set_NormalizedUserName("adm@depoisdalinha.com.br");
            app1.set_Email("adm@depoisdalinha.com.br");
            app1.set_NormalizedEmail("adm@depoisdalinha.com.br");
            app1.set_EmailConfirmed(true);
            app1.set_PasswordHash(hasher.HashPassword(null, "S3nh4DepoisDaLinha@010203"));
            app1.set_SecurityStamp(string.Empty);
            app1.AvatarUsuario = CriptografiaHelper.Encriptar("/images/avatar-boodah.jpg", "", "");
            app1.Sistema_FuncaoUsuario = CriptografiaHelper.Encriptar("SISTEMA", "", "");
            app1.Nome = CriptografiaHelper.Encriptar("Depois", "", "");
            app1.Sobrenome = CriptografiaHelper.Encriptar("da Linha", "", "");
            app1.Bio = CriptografiaHelper.Encriptar("Depois da Linha", "", "");
            app1.ContatoAutenticacao_Email = CriptografiaHelper.Encriptar("leandrodiascarvalho@hotmail.com", "", "");
            app1.ContatoAutenticacao_EmailAlternativo = CriptografiaHelper.Encriptar("sistemasolarium@gmail.com", "", "");
            app1.ContatoAutenticacao_Fone = CriptografiaHelper.Encriptar("+5511998814900", "", "");
            app1.ContatoAutenticacao_FoneAlternativo = CriptografiaHelper.Encriptar("+551126917524", "", "");
            app1.Contato_Bairro = CriptografiaHelper.Encriptar("JD. NOSSA SENHORA DO CARMO", "", "");
            app1.Contato_CEP = CriptografiaHelper.Encriptar("08275010", "", "");
            app1.Contato_Cidade = CriptografiaHelper.Encriptar("S\x00c3O PAULO", "", "");
            app1.Contato_Complemento = CriptografiaHelper.Encriptar("SEM COMPLEMENTO", "", "");
            app1.Contato_Escritorio = CriptografiaHelper.Encriptar("RUA MATEUS MENDES PEREIRA, 312, JD. NOSSA SENHORA DO CARMO, SP, 08275-010", "", "");
            app1.Contato_Estado = CriptografiaHelper.Encriptar("SP", "", "");
            app1.Contato_FoneCelular = CriptografiaHelper.Encriptar("+5511998814900", "", "");
            app1.Contato_FoneComercial = CriptografiaHelper.Encriptar("+551126917524", "", "");
            app1.Contato_Logradouro = CriptografiaHelper.Encriptar("RUA MATEUS MENDES PEREIRA, 312", "", "");
            app1.Contato_Pais = CriptografiaHelper.Encriptar("BRASIL", "", "");
            app1.Contato_Website = CriptografiaHelper.Encriptar("https://www.depoisdalinha.com.br", "", "");
            app1.Genero = CriptografiaHelper.Encriptar("MASCULINO", "", "");
            app1.ImagemFundoPerfil = "/images/fundo_padrao_perfil.png";
            app1.MidiasSociais_Facebook = "";
            app1.MidiasSociais_GooglePlus = "";
            app1.MidiasSociais_Instagram = "";
            app1.MidiasSociais_Linkedin = "";
            app1.MidiasSociais_Pinterest = "";
            app1.MidiasSociais_Twitter = "";
            app1.MidiasSociais_Youtube = "";
            app1.Nascimento = new DateTime(0x7ba, 2, 14);
            app1.set_PhoneNumber("+5511998814900");
            app1.set_PhoneNumberConfirmed(true);
            app1.set_LockoutEnabled(false);
            app1.Trabalho_Empresa = CriptografiaHelper.Encriptar("DEPOIS DA LINHA", "", "");
            app1.Trabalho_Cargo = CriptografiaHelper.Encriptar("SEO E DESENVOLVEDOR", "", "");
            app1.Trabalho_Profissao = CriptografiaHelper.Encriptar("PROGRAMADOR", "", "");
            app1.set_TwoFactorEnabled(false);
            app1.Documentacao_CNPJ = CriptografiaHelper.Encriptar("14.581.834/0001-42", "", "");
            app1.Documentacao_CPF = CriptografiaHelper.Encriptar("215.954.848-09", "", "");
            app1.Documentacao_RG = CriptografiaHelper.Encriptar("30.017.827-x", "", "");
            app1.Documentacao_TPPessoa = CriptografiaHelper.Encriptar("PF", "", "");
            app1.EstadoCivil = CriptografiaHelper.Encriptar("CASADO", "", "");
            app1.Financeiro_Banco_Nome = "";
            app1.Financeiro_Banco_Ag = "";
            app1.Financeiro_Banco_CC = "";
            app1.Sistema_DeclaracaoCienciaTermos = true;
            app1.Sistema_DataDeclaracaoCienciaTermos = DateTime.get_Now();
            app1.Sistema_URLComprovanteResidencia = "";
            app1.Sistema_URLSelfieDocFRENTE = "";
            app1.Sistema_URLFotoDoc = "";
            app1.Sistema_URLSelfieDocVERSO = "";
            app1.Financeiro_Investidor_Perfil = CriptografiaHelper.Encriptar("SISTEMA", "", "");
            UsuarioApp[] appArray1 = new UsuarioApp[5];
            appArray1[0] = app1;
            UsuarioApp app2 = new UsuarioApp();
            app2.set_Id("b1aadecb-4357-457d-bfea-27e153505497");
            app2.AppConfiguracoesId = 1;
            app2.Sistema_AcessoBloqueado = false;
            app2.set_UserName("adm@house2invest.com.br");
            app2.set_NormalizedUserName("adm@house2invest.com.br");
            app2.set_Email("adm@house2invest.com.br");
            app2.set_NormalizedEmail("adm@house2invest.com.br");
            app2.set_EmailConfirmed(true);
            app2.set_PasswordHash(hasher.HashPassword(null, "S3nh4House2Invest@010203"));
            app2.set_SecurityStamp(string.Empty);
            app2.AvatarUsuario = CriptografiaHelper.Encriptar("/images/avatar-house-2-invest.png", "", "");
            app2.Sistema_FuncaoUsuario = CriptografiaHelper.Encriptar("SISTEMA", "", "");
            app2.Nome = CriptografiaHelper.Encriptar("House", "", "");
            app2.Sobrenome = CriptografiaHelper.Encriptar("2Invest", "", "");
            app2.Bio = CriptografiaHelper.Encriptar("House2Invest", "", "");
            app2.ContatoAutenticacao_Email = CriptografiaHelper.Encriptar("dr.vitor@totalvascular.com.br", "", "");
            app2.ContatoAutenticacao_EmailAlternativo = CriptografiaHelper.Encriptar("dr.vitor@totalvascular.com.br", "", "");
            app2.ContatoAutenticacao_Fone = CriptografiaHelper.Encriptar("+5511995951925", "", "");
            app2.ContatoAutenticacao_FoneAlternativo = CriptografiaHelper.Encriptar("+5511995951925", "", "");
            app2.Contato_Bairro = CriptografiaHelper.Encriptar("PACAEMBU", "", "");
            app2.Contato_CEP = CriptografiaHelper.Encriptar("01234010", "", "");
            app2.Contato_Cidade = CriptografiaHelper.Encriptar("S\x00c3O PAULO", "", "");
            app2.Contato_Complemento = CriptografiaHelper.Encriptar("SEM COMPLEMENTO", "", "");
            app2.Contato_Escritorio = CriptografiaHelper.Encriptar("AVENIDA PACAEMBU, 1882, PACAEMBU, SP, 01234-010", "", "");
            app2.Contato_Estado = CriptografiaHelper.Encriptar("SP", "", "");
            app2.Contato_FoneCelular = CriptografiaHelper.Encriptar("+5511995951925", "", "");
            app2.Contato_FoneComercial = CriptografiaHelper.Encriptar("+5511995951925", "", "");
            app2.Contato_Logradouro = CriptografiaHelper.Encriptar("AVENIDA PACAEMBU, 1882", "", "");
            app2.Contato_Pais = CriptografiaHelper.Encriptar("BRASIL", "", "");
            app2.Contato_Website = CriptografiaHelper.Encriptar("https://www.house2invest.com.br", "", "");
            app2.Genero = CriptografiaHelper.Encriptar("MASCULINO", "", "");
            app2.ImagemFundoPerfil = "/images/fundo_padrao_perfil.png";
            app2.MidiasSociais_Facebook = "";
            app2.MidiasSociais_GooglePlus = "";
            app2.MidiasSociais_Instagram = "";
            app2.MidiasSociais_Linkedin = "";
            app2.MidiasSociais_Pinterest = "";
            app2.MidiasSociais_Twitter = "";
            app2.MidiasSociais_Youtube = "";
            app2.Nascimento = new DateTime(0x7ba, 2, 14);
            app2.set_PhoneNumber("+5511995951925");
            app2.set_PhoneNumberConfirmed(true);
            app2.set_LockoutEnabled(false);
            app2.Trabalho_Empresa = CriptografiaHelper.Encriptar("HOUSE2INVEST", "", "");
            app2.Trabalho_Cargo = CriptografiaHelper.Encriptar("M\x00c9DICO", "", "");
            app2.Trabalho_Profissao = CriptografiaHelper.Encriptar("M\x00c9DICO", "", "");
            app2.set_TwoFactorEnabled(false);
            app2.Documentacao_CNPJ = CriptografiaHelper.Encriptar("00.000.000/0000-00", "", "");
            app2.Documentacao_CPF = CriptografiaHelper.Encriptar("000.000.000-00", "", "");
            app2.Documentacao_RG = CriptografiaHelper.Encriptar("00.000.000-0", "", "");
            app2.Documentacao_TPPessoa = CriptografiaHelper.Encriptar("PF", "", "");
            app2.EstadoCivil = CriptografiaHelper.Encriptar("CASADO", "", "");
            app2.Financeiro_Banco_Nome = "";
            app2.Financeiro_Banco_Ag = "";
            app2.Financeiro_Banco_CC = "";
            app2.Sistema_DeclaracaoCienciaTermos = true;
            app2.Sistema_DataDeclaracaoCienciaTermos = DateTime.get_Now();
            app2.Sistema_URLComprovanteResidencia = "";
            app2.Sistema_URLSelfieDocFRENTE = "";
            app2.Sistema_URLFotoDoc = "";
            app2.Sistema_URLSelfieDocVERSO = "";
            app2.Financeiro_Investidor_Perfil = CriptografiaHelper.Encriptar("SISTEMA", "", "");
            appArray1[1] = app2;
            UsuarioApp app3 = new UsuarioApp();
            app3.set_Id("4cb6d3d8-493a-415c-a5d7-cc6860aa8691");
            app3.AppConfiguracoesId = 1;
            app3.Sistema_AcessoBloqueado = false;
            app3.set_UserName("vitor@house2invest.com.br");
            app3.set_NormalizedUserName("vitor@house2invest.com.br");
            app3.set_Email("vitor@house2invest.com.br");
            app3.set_NormalizedEmail("vitor@house2invest.com.br");
            app3.set_EmailConfirmed(true);
            app3.set_PasswordHash(hasher.HashPassword(null, "S3nh4Vitor@010203"));
            app3.set_SecurityStamp(string.Empty);
            app3.AvatarUsuario = CriptografiaHelper.Encriptar("/images/avatar-vitor.jpg", "", "");
            app3.Sistema_FuncaoUsuario = CriptografiaHelper.Encriptar("SISTEMA", "", "");
            app3.Nome = CriptografiaHelper.Encriptar("VITOR", "", "");
            app3.Sobrenome = CriptografiaHelper.Encriptar("CERVANTES GORNATI", "", "");
            app3.Bio = CriptografiaHelper.Encriptar("House2Invest", "", "");
            app3.ContatoAutenticacao_Email = CriptografiaHelper.Encriptar("dr.vitor@totalvascular.com.br", "", "");
            app3.ContatoAutenticacao_EmailAlternativo = CriptografiaHelper.Encriptar("dr.vitor@totalvascular.com.br", "", "");
            app3.ContatoAutenticacao_Fone = CriptografiaHelper.Encriptar("+5511995951925", "", "");
            app3.ContatoAutenticacao_FoneAlternativo = CriptografiaHelper.Encriptar("+5511995951925", "", "");
            app3.Contato_Bairro = CriptografiaHelper.Encriptar("PACAEMBU", "", "");
            app3.Contato_CEP = CriptografiaHelper.Encriptar("01234010", "", "");
            app3.Contato_Cidade = CriptografiaHelper.Encriptar("S\x00c3O PAULO", "", "");
            app3.Contato_Complemento = CriptografiaHelper.Encriptar("SEM COMPLEMENTO", "", "");
            app3.Contato_Escritorio = CriptografiaHelper.Encriptar("AVENIDA PACAEMBU, 1882, PACAEMBU, SP, 01234-010", "", "");
            app3.Contato_Estado = CriptografiaHelper.Encriptar("SP", "", "");
            app3.Contato_FoneCelular = CriptografiaHelper.Encriptar("+5511995951925", "", "");
            app3.Contato_FoneComercial = CriptografiaHelper.Encriptar("+5511995951925", "", "");
            app3.Contato_Logradouro = CriptografiaHelper.Encriptar("AVENIDA PACAEMBU, 1882", "", "");
            app3.Contato_Pais = CriptografiaHelper.Encriptar("BRASIL", "", "");
            app3.Contato_Website = CriptografiaHelper.Encriptar("https://www.house2invest.com.br", "", "");
            app3.Genero = CriptografiaHelper.Encriptar("MASCULINO", "", "");
            app3.ImagemFundoPerfil = "/images/fundo_padrao_perfil.png";
            app3.MidiasSociais_Facebook = "";
            app3.MidiasSociais_GooglePlus = "";
            app3.MidiasSociais_Instagram = "";
            app3.MidiasSociais_Linkedin = "";
            app3.MidiasSociais_Pinterest = "";
            app3.MidiasSociais_Twitter = "";
            app3.MidiasSociais_Youtube = "";
            app3.Nascimento = new DateTime(0x7ba, 2, 14);
            app3.set_PhoneNumber("+5511995951925");
            app3.set_PhoneNumberConfirmed(true);
            app3.set_LockoutEnabled(false);
            app3.Trabalho_Empresa = CriptografiaHelper.Encriptar("HOUSE2INVEST", "", "");
            app3.Trabalho_Cargo = CriptografiaHelper.Encriptar("M\x00c9DICO", "", "");
            app3.Trabalho_Profissao = CriptografiaHelper.Encriptar("M\x00c9DICO", "", "");
            app3.set_TwoFactorEnabled(false);
            app3.Documentacao_CNPJ = CriptografiaHelper.Encriptar("00.000.000/0000-00", "", "");
            app3.Documentacao_CPF = CriptografiaHelper.Encriptar("000.000.000-00", "", "");
            app3.Documentacao_RG = CriptografiaHelper.Encriptar("00.000.000-0", "", "");
            app3.Documentacao_TPPessoa = CriptografiaHelper.Encriptar("PF", "", "");
            app3.EstadoCivil = CriptografiaHelper.Encriptar("CASADO", "", "");
            app3.Financeiro_Banco_Nome = "";
            app3.Financeiro_Banco_Ag = "";
            app3.Financeiro_Banco_CC = "";
            app3.Sistema_DeclaracaoCienciaTermos = true;
            app3.Sistema_DataDeclaracaoCienciaTermos = DateTime.get_Now();
            app3.Sistema_URLComprovanteResidencia = "";
            app3.Sistema_URLSelfieDocFRENTE = "";
            app3.Sistema_URLFotoDoc = "";
            app3.Sistema_URLSelfieDocVERSO = "";
            app3.Financeiro_Investidor_Perfil = CriptografiaHelper.Encriptar("SISTEMA", "", "");
            appArray1[2] = app3;
            UsuarioApp app4 = new UsuarioApp();
            app4.set_Id("bbf7b44d-faa0-4276-b163-295b780a062c");
            app4.AppConfiguracoesId = 1;
            app4.Sistema_AcessoBloqueado = false;
            app4.set_UserName("joao@house2invest.com.br");
            app4.set_NormalizedUserName("joao@house2invest.com.br");
            app4.set_Email("joao@house2invest.com.br");
            app4.set_NormalizedEmail("joao@house2invest.com.br");
            app4.set_EmailConfirmed(true);
            app4.set_PasswordHash(hasher.HashPassword(null, "S3nh4Joao@010203"));
            app4.set_SecurityStamp(string.Empty);
            app4.AvatarUsuario = CriptografiaHelper.Encriptar("/images/avatar-joao.jpg", "", "");
            app4.Sistema_FuncaoUsuario = CriptografiaHelper.Encriptar("SISTEMA", "", "");
            app4.Nome = CriptografiaHelper.Encriptar("JO\x00c3O", "", "");
            app4.Sobrenome = CriptografiaHelper.Encriptar("PAULO MARTINS", "", "");
            app4.Bio = CriptografiaHelper.Encriptar("House2Invest", "", "");
            app4.ContatoAutenticacao_Email = CriptografiaHelper.Encriptar("jpmartins@incorporadorabravo.com.br", "", "");
            app4.ContatoAutenticacao_EmailAlternativo = CriptografiaHelper.Encriptar("jpmartins@incorporadorabravo.com.br", "", "");
            app4.ContatoAutenticacao_Fone = CriptografiaHelper.Encriptar("+5511979661000", "", "");
            app4.ContatoAutenticacao_FoneAlternativo = CriptografiaHelper.Encriptar("+5511979661000", "", "");
            app4.Contato_Bairro = CriptografiaHelper.Encriptar("VILA MENDON\x00c7A", "", "");
            app4.Contato_CEP = CriptografiaHelper.Encriptar("16015080", "", "");
            app4.Contato_Cidade = CriptografiaHelper.Encriptar("ARA\x00c7ATUBA", "", "");
            app4.Contato_Complemento = CriptografiaHelper.Encriptar("SEM COMPLEMENTO", "", "");
            app4.Contato_Escritorio = CriptografiaHelper.Encriptar("AV. DO ESTADOS, 416", "", "");
            app4.Contato_Estado = CriptografiaHelper.Encriptar("SP", "", "");
            app4.Contato_FoneCelular = CriptografiaHelper.Encriptar("+5511979661000", "", "");
            app4.Contato_FoneComercial = CriptografiaHelper.Encriptar("+5511979661000", "", "");
            app4.Contato_Logradouro = CriptografiaHelper.Encriptar("AV. DO ESTADOS, 416", "", "");
            app4.Contato_Pais = CriptografiaHelper.Encriptar("BRASIL", "", "");
            app4.Contato_Website = CriptografiaHelper.Encriptar("https://www.house2invest.com.br", "", "");
            app4.Genero = CriptografiaHelper.Encriptar("MASCULINO", "", "");
            app4.ImagemFundoPerfil = "/images/fundo_padrao_perfil.png";
            app4.MidiasSociais_Facebook = "";
            app4.MidiasSociais_GooglePlus = "";
            app4.MidiasSociais_Instagram = "";
            app4.MidiasSociais_Linkedin = "";
            app4.MidiasSociais_Pinterest = "";
            app4.MidiasSociais_Twitter = "";
            app4.MidiasSociais_Youtube = "";
            app4.Nascimento = new DateTime(0x7ba, 2, 14);
            app4.set_PhoneNumber("+5511979661000");
            app4.set_PhoneNumberConfirmed(true);
            app4.set_LockoutEnabled(false);
            app4.Trabalho_Empresa = CriptografiaHelper.Encriptar("HOUSE2INVEST", "", "");
            app4.Trabalho_Cargo = CriptografiaHelper.Encriptar("ADMINISTRADOR", "", "");
            app4.Trabalho_Profissao = CriptografiaHelper.Encriptar("ADMINISTRADOR", "", "");
            app4.set_TwoFactorEnabled(false);
            app4.Documentacao_CNPJ = CriptografiaHelper.Encriptar("00.000.000/0000-00", "", "");
            app4.Documentacao_CPF = CriptografiaHelper.Encriptar("000.000.000-00", "", "");
            app4.Documentacao_RG = CriptografiaHelper.Encriptar("00.000.000-0", "", "");
            app4.Documentacao_TPPessoa = CriptografiaHelper.Encriptar("PF", "", "");
            app4.EstadoCivil = CriptografiaHelper.Encriptar("CASADO", "", "");
            app4.Financeiro_Banco_Nome = "";
            app4.Financeiro_Banco_Ag = "";
            app4.Financeiro_Banco_CC = "";
            app4.Sistema_DeclaracaoCienciaTermos = true;
            app4.Sistema_DataDeclaracaoCienciaTermos = DateTime.get_Now();
            app4.Sistema_URLComprovanteResidencia = "";
            app4.Sistema_URLSelfieDocFRENTE = "";
            app4.Sistema_URLFotoDoc = "";
            app4.Sistema_URLSelfieDocVERSO = "";
            app4.Financeiro_Investidor_Perfil = CriptografiaHelper.Encriptar("SISTEMA", "", "");
            appArray1[3] = app4;
            UsuarioApp app5 = new UsuarioApp();
            app5.set_Id("2751483e-2c65-4629-84b5-abc20c940c1c");
            app5.AppConfiguracoesId = 1;
            app5.Sistema_AcessoBloqueado = false;
            app5.set_UserName("cristina@house2invest.com.br");
            app5.set_NormalizedUserName("cristina@house2invest.com.br");
            app5.set_Email("cristina@house2invest.com.br");
            app5.set_NormalizedEmail("cristina@house2invest.com.br");
            app5.set_EmailConfirmed(true);
            app5.set_PasswordHash(hasher.HashPassword(null, "S3nh4Cristina@010203"));
            app5.set_SecurityStamp(string.Empty);
            app5.AvatarUsuario = CriptografiaHelper.Encriptar("/images/avatar-cris.jpg", "", "");
            app5.Sistema_FuncaoUsuario = CriptografiaHelper.Encriptar("SISTEMA", "", "");
            app5.Nome = CriptografiaHelper.Encriptar("CRISTINA", "", "");
            app5.Sobrenome = CriptografiaHelper.Encriptar("LOSCHIAVO PEPINO", "", "");
            app5.Bio = CriptografiaHelper.Encriptar("House2Invest", "", "");
            app5.ContatoAutenticacao_Email = CriptografiaHelper.Encriptar("crisrizz@yahoo.com.br", "", "");
            app5.ContatoAutenticacao_EmailAlternativo = CriptografiaHelper.Encriptar("crisrizz@yahoo.com.br", "", "");
            app5.ContatoAutenticacao_Fone = CriptografiaHelper.Encriptar("+5511997103699", "", "");
            app5.ContatoAutenticacao_FoneAlternativo = CriptografiaHelper.Encriptar("+5511997103699", "", "");
            app5.Contato_Bairro = CriptografiaHelper.Encriptar("BELA VISTA", "", "");
            app5.Contato_CEP = CriptografiaHelper.Encriptar("01310300", "", "");
            app5.Contato_Cidade = CriptografiaHelper.Encriptar("S\x00c3O PAULO", "", "");
            app5.Contato_Complemento = CriptografiaHelper.Encriptar("CJ 113", "", "");
            app5.Contato_Escritorio = CriptografiaHelper.Encriptar("AV. PAULISTA, 2202", "", "");
            app5.Contato_Estado = CriptografiaHelper.Encriptar("SP", "", "");
            app5.Contato_FoneCelular = CriptografiaHelper.Encriptar("+5511997103699", "", "");
            app5.Contato_FoneComercial = CriptografiaHelper.Encriptar("+5511997103699", "", "");
            app5.Contato_Logradouro = CriptografiaHelper.Encriptar("AV. PAULISTA, 2202", "", "");
            app5.Contato_Pais = CriptografiaHelper.Encriptar("BRASIL", "", "");
            app5.Contato_Website = CriptografiaHelper.Encriptar("https://www.house2invest.com.br", "", "");
            app5.Genero = CriptografiaHelper.Encriptar("FEMININO", "", "");
            app5.ImagemFundoPerfil = "/images/fundo_padrao_perfil.png";
            app5.MidiasSociais_Facebook = "";
            app5.MidiasSociais_GooglePlus = "";
            app5.MidiasSociais_Instagram = "";
            app5.MidiasSociais_Linkedin = "";
            app5.MidiasSociais_Pinterest = "";
            app5.MidiasSociais_Twitter = "";
            app5.MidiasSociais_Youtube = "";
            app5.Nascimento = new DateTime(0x7ba, 2, 14);
            app5.set_PhoneNumber("+5511997103699");
            app5.set_PhoneNumberConfirmed(true);
            app5.set_LockoutEnabled(false);
            app5.Trabalho_Empresa = CriptografiaHelper.Encriptar("HOUSE2INVEST", "", "");
            app5.Trabalho_Cargo = CriptografiaHelper.Encriptar("ADVOGADA", "", "");
            app5.Trabalho_Profissao = CriptografiaHelper.Encriptar("ADVOGADA", "", "");
            app5.set_TwoFactorEnabled(false);
            app5.Documentacao_CNPJ = CriptografiaHelper.Encriptar("00.000.000/0000-00", "", "");
            app5.Documentacao_CPF = CriptografiaHelper.Encriptar("000.000.000-00", "", "");
            app5.Documentacao_RG = CriptografiaHelper.Encriptar("00.000.000-0", "", "");
            app5.Documentacao_TPPessoa = CriptografiaHelper.Encriptar("PF", "", "");
            app5.EstadoCivil = CriptografiaHelper.Encriptar("CASADA", "", "");
            app5.Financeiro_Banco_Nome = "";
            app5.Financeiro_Banco_Ag = "";
            app5.Financeiro_Banco_CC = "";
            app5.Sistema_DeclaracaoCienciaTermos = true;
            app5.Sistema_DataDeclaracaoCienciaTermos = DateTime.get_Now();
            app5.Sistema_URLComprovanteResidencia = "";
            app5.Sistema_URLSelfieDocFRENTE = "";
            app5.Sistema_URLFotoDoc = "";
            app5.Sistema_URLSelfieDocVERSO = "";
            app5.Financeiro_Investidor_Perfil = CriptografiaHelper.Encriptar("SISTEMA", "", "");
            appArray1[4] = app5;
            modelBuilder.Entity<UsuarioApp>().HasData(appArray1);
            IdentityUserRole<string> role15 = new IdentityUserRole<string>();
            role15.set_RoleId("59c39ee9-024a-41c1-bae8-7859879aa9f2");
            role15.set_UserId("b30b4d21-0f99-435e-acec-a2c672697b0f");
            IdentityUserRole<string>[] roleArray2 = new IdentityUserRole<string>[5];
            roleArray2[0] = role15;
            IdentityUserRole<string> role16 = new IdentityUserRole<string>();
            role16.set_RoleId("59c39ee9-024a-41c1-bae8-7859879aa9f2");
            role16.set_UserId("b1aadecb-4357-457d-bfea-27e153505497");
            roleArray2[1] = role16;
            IdentityUserRole<string> role17 = new IdentityUserRole<string>();
            role17.set_RoleId("59c39ee9-024a-41c1-bae8-7859879aa9f2");
            role17.set_UserId("4cb6d3d8-493a-415c-a5d7-cc6860aa8691");
            roleArray2[2] = role17;
            IdentityUserRole<string> role18 = new IdentityUserRole<string>();
            role18.set_RoleId("59c39ee9-024a-41c1-bae8-7859879aa9f2");
            role18.set_UserId("bbf7b44d-faa0-4276-b163-295b780a062c");
            roleArray2[3] = role18;
            IdentityUserRole<string> role19 = new IdentityUserRole<string>();
            role19.set_RoleId("59c39ee9-024a-41c1-bae8-7859879aa9f2");
            role19.set_UserId("2751483e-2c65-4629-84b5-abc20c940c1c");
            roleArray2[4] = role19;
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(roleArray2);
        }

        public DbSet<SEO_Visita> SEO_Visitas
        {
            get
            {
                return this.<SEO_Visitas>k__BackingField;
            }
            set
            {
                this.<SEO_Visitas>k__BackingField = value;
            }
        }

        public DbSet<House2Invest.Models.AppPerfil> AppPerfil
        {
            get
            {
                return this.<AppPerfil>k__BackingField;
            }
            set
            {
                this.<AppPerfil>k__BackingField = value;
            }
        }

        public DbSet<House2Invest.Models.AppConfiguracoes> AppConfiguracoes
        {
            get
            {
                return this.<AppConfiguracoes>k__BackingField;
            }
            set
            {
                this.<AppConfiguracoes>k__BackingField = value;
            }
        }

        public DbSet<House2Invest.Models.AppConfiguracoes_Aplicativo> AppConfiguracoes_Aplicativo
        {
            get
            {
                return this.<AppConfiguracoes_Aplicativo>k__BackingField;
            }
            set
            {
                this.<AppConfiguracoes_Aplicativo>k__BackingField = value;
            }
        }

        public DbSet<House2Invest.Models.AppConfiguracoes_Azure> AppConfiguracoes_Azure
        {
            get
            {
                return this.<AppConfiguracoes_Azure>k__BackingField;
            }
            set
            {
                this.<AppConfiguracoes_Azure>k__BackingField = value;
            }
        }

        public DbSet<House2Invest.Models.GaleriaPerfilAlbum> GaleriaPerfilAlbum
        {
            get
            {
                return this.<GaleriaPerfilAlbum>k__BackingField;
            }
            set
            {
                this.<GaleriaPerfilAlbum>k__BackingField = value;
            }
        }

        public DbSet<House2Invest.Models.GaleriaPerfilImagem> GaleriaPerfilImagem
        {
            get
            {
                return this.<GaleriaPerfilImagem>k__BackingField;
            }
            set
            {
                this.<GaleriaPerfilImagem>k__BackingField = value;
            }
        }

        public DbSet<BlocoProjInvestimento> BlocoProjInvestimentos
        {
            get
            {
                return this.<BlocoProjInvestimentos>k__BackingField;
            }
            set
            {
                this.<BlocoProjInvestimentos>k__BackingField = value;
            }
        }

        public DbSet<BlocoProjInvestimento_ItemDoc> BlocoProjInvestimento_ItemDocs
        {
            get
            {
                return this.<BlocoProjInvestimento_ItemDocs>k__BackingField;
            }
            set
            {
                this.<BlocoProjInvestimento_ItemDocs>k__BackingField = value;
            }
        }

        public DbSet<BlocoProjInvestimentoValor> BlocoProjInvestimentoValores
        {
            get
            {
                return this.<BlocoProjInvestimentoValores>k__BackingField;
            }
            set
            {
                this.<BlocoProjInvestimentoValores>k__BackingField = value;
            }
        }

        public DbSet<BlocoProjInvestimentoComentario> BlocoProjInvestimentoComentarios
        {
            get
            {
                return this.<BlocoProjInvestimentoComentarios>k__BackingField;
            }
            set
            {
                this.<BlocoProjInvestimentoComentarios>k__BackingField = value;
            }
        }

        public DbSet<INVEST_ModeloDoc> INVEST_ModeloDocs
        {
            get
            {
                return this.<INVEST_ModeloDocs>k__BackingField;
            }
            set
            {
                this.<INVEST_ModeloDocs>k__BackingField = value;
            }
        }

        public DbSet<INVEST_LancamentoDoc> INVEST_LancamentoDocs
        {
            get
            {
                return this.<INVEST_LancamentoDocs>k__BackingField;
            }
            set
            {
                this.<INVEST_LancamentoDocs>k__BackingField = value;
            }
        }

        public DbSet<INVEST_LancamentoImagem> INVEST_LancamentoImagens
        {
            get
            {
                return this.<INVEST_LancamentoImagens>k__BackingField;
            }
            set
            {
                this.<INVEST_LancamentoImagens>k__BackingField = value;
            }
        }

        public DbSet<INVEST_Lancamento> INVEST_Lancamentos
        {
            get
            {
                return this.<INVEST_Lancamentos>k__BackingField;
            }
            set
            {
                this.<INVEST_Lancamentos>k__BackingField = value;
            }
        }

        public DbSet<LOGCENTRAL> LOGCENTRALs
        {
            get
            {
                return this.<LOGCENTRALs>k__BackingField;
            }
            set
            {
                this.<LOGCENTRALs>k__BackingField = value;
            }
        }

        public DbSet<LOGACOESUSU> LOGACOESUSUs
        {
            get
            {
                return this.<LOGACOESUSUs>k__BackingField;
            }
            set
            {
                this.<LOGACOESUSUs>k__BackingField = value;
            }
        }

        public DbSet<tblHubConversa> tblHubConversas
        {
            get
            {
                return this.<tblHubConversas>k__BackingField;
            }
            set
            {
                this.<tblHubConversas>k__BackingField = value;
            }
        }

        public DbSet<tblHubCliente> tblHubClientes
        {
            get
            {
                return this.<tblHubClientes>k__BackingField;
            }
            set
            {
                this.<tblHubClientes>k__BackingField = value;
            }
        }

        public DbSet<PreferSalaVIP> PreferSalaVIPs
        {
            get
            {
                return this.<PreferSalaVIPs>k__BackingField;
            }
            set
            {
                this.<PreferSalaVIPs>k__BackingField = value;
            }
        }

        public DbSet<tblUsuSalaVIP> tblUsuSalaVIPs
        {
            get
            {
                return this.<tblUsuSalaVIPs>k__BackingField;
            }
            set
            {
                this.<tblUsuSalaVIPs>k__BackingField = value;
            }
        }

        public DbSet<INVEST_ControleTransf> INVEST_ControleTransfs
        {
            get
            {
                return this.<INVEST_ControleTransfs>k__BackingField;
            }
            set
            {
                this.<INVEST_ControleTransfs>k__BackingField = value;
            }
        }

        public DbSet<HgGeoIp> HgGeoIps
        {
            get
            {
                return this.<HgGeoIps>k__BackingField;
            }
            set
            {
                this.<HgGeoIps>k__BackingField = value;
            }
        }

        public DbSet<ResultsGeoIp> ResultsGeoIps
        {
            get
            {
                return this.<ResultsGeoIps>k__BackingField;
            }
            set
            {
                this.<ResultsGeoIps>k__BackingField = value;
            }
        }

        public DbSet<HgGeoIp_Pais> HgGeoIp_Paises
        {
            get
            {
                return this.<HgGeoIp_Paises>k__BackingField;
            }
            set
            {
                this.<HgGeoIp_Paises>k__BackingField = value;
            }
        }

        public DbSet<HgGeoIp_Pais_Flag> HgGeoIp_Pais_Flags
        {
            get
            {
                return this.<HgGeoIp_Pais_Flags>k__BackingField;
            }
            set
            {
                this.<HgGeoIp_Pais_Flags>k__BackingField = value;
            }
        }

        public DbSet<TaxaMercado> TaxaMercados
        {
            get
            {
                return this.<TaxaMercados>k__BackingField;
            }
            set
            {
                this.<TaxaMercados>k__BackingField = value;
            }
        }

        public DbSet<Construtora> Construtoras
        {
            get
            {
                return this.<Construtoras>k__BackingField;
            }
            set
            {
                this.<Construtoras>k__BackingField = value;
            }
        }

        public DbSet<TaxaGLOBAL> TaxasGLOBAIS
        {
            get
            {
                return this.<TaxasGLOBAIS>k__BackingField;
            }
            set
            {
                this.<TaxasGLOBAIS>k__BackingField = value;
            }
        }

        public DbSet<InvestimentoDocUsuario> InvestimentoDocUsuarios
        {
            get
            {
                return this.<InvestimentoDocUsuarios>k__BackingField;
            }
            set
            {
                this.<InvestimentoDocUsuarios>k__BackingField = value;
            }
        }

        public DbSet<InvestimentoConfirmacao> InvestimentoConfirmacoes
        {
            get
            {
                return this.<InvestimentoConfirmacoes>k__BackingField;
            }
            set
            {
                this.<InvestimentoConfirmacoes>k__BackingField = value;
            }
        }

        public DbSet<House2Invest.Models.DUMPSQL> DUMPSQL
        {
            get
            {
                return this.<DUMPSQL>k__BackingField;
            }
            set
            {
                this.<DUMPSQL>k__BackingField = value;
            }
        }

        public DbSet<House2Invest.Models.FAQ> FAQ
        {
            get
            {
                return this.<FAQ>k__BackingField;
            }
            set
            {
                this.<FAQ>k__BackingField = value;
            }
        }

        public DbSet<FAQItem> FAQItens
        {
            get
            {
                return this.<FAQItens>k__BackingField;
            }
            set
            {
                this.<FAQItens>k__BackingField = value;
            }
        }

        public DbSet<Transferencia> Tranferencias
        {
            get
            {
                return this.<Tranferencias>k__BackingField;
            }
            set
            {
                this.<Tranferencias>k__BackingField = value;
            }
        }
    }
}

